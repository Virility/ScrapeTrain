using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrapeTrain.Core.Helpers;
using ScrapeTrain.Core.Models;
using ScrapeTrain.Core.Providers;

namespace ScrapeTrain.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly TrakTrainProvider _provider;
        private ArtistInfo _artistInfo;
        
        public MainForm()
        {
            _provider = new TrakTrainProvider();
            InitializeComponent();
            tbBaseDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private async void bGetTracks_Click(object sender, EventArgs e)
        {
            _artistInfo = await _provider.GetArtistInfo(textBox1.Text);
            if (_artistInfo == null)
            {
                Debug.WriteLine("Not found");
                return;
            }

            Text = _artistInfo.Name;
            foreach (var bareTrackInfo in _artistInfo.BareTrackInfos)
                clbTracks.Items.Add(bareTrackInfo);
        }

        private void tbBaseDirectory_DoubleClick(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    tbBaseDirectory.Text = dialog.SelectedPath;
            }
        }

        private async void bDownloadChecked_Click(object sender, EventArgs e)
        {
            var directoryPath = Path.Combine(tbBaseDirectory.Text, SanitizeHelper.ForPath(_artistInfo.Name).Trim());
            Directory.CreateDirectory(directoryPath);

            var downloadTaskList = new List<Task>();
            foreach (int checkedIndex in clbTracks.CheckedIndices)
                downloadTaskList.Add(GetTrackThenDownload(directoryPath, _artistInfo.BareTrackInfos[checkedIndex]));
            await Task.WhenAll(downloadTaskList.ToArray());
        }

        private async Task GetTrackThenDownload(string directoryPath, BareTrackInfo bareTrackInfo)
        {
            var trackInfo = await bareTrackInfo.GetTrackInfo();
            var fileName = Path.Combine(directoryPath, SanitizeHelper.ForFileName(trackInfo.Name) + ".mp3");
            var data = await _provider.GetDownloadAsByteArray(trackInfo);

            using (FileStream sourceStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                await sourceStream.WriteAsync(data, 0, data.Length);
        }
    }
}