namespace ScrapeTrain.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bGetTracks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbBaseDirectory = new System.Windows.Forms.TextBox();
            this.lbBaseDirectory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbTracks = new System.Windows.Forms.CheckedListBox();
            this.bDownloadChecked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGetTracks
            // 
            this.bGetTracks.Location = new System.Drawing.Point(197, 23);
            this.bGetTracks.Name = "bGetTracks";
            this.bGetTracks.Size = new System.Drawing.Size(113, 23);
            this.bGetTracks.TabIndex = 0;
            this.bGetTracks.Text = "Get Tracks";
            this.bGetTracks.UseVisualStyleBackColor = true;
            this.bGetTracks.Click += new System.EventHandler(this.bGetTracks_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 21);
            this.textBox1.TabIndex = 1;
            // 
            // tbBaseDirectory
            // 
            this.tbBaseDirectory.Location = new System.Drawing.Point(15, 412);
            this.tbBaseDirectory.Name = "tbBaseDirectory";
            this.tbBaseDirectory.Size = new System.Drawing.Size(295, 21);
            this.tbBaseDirectory.TabIndex = 2;
            this.tbBaseDirectory.DoubleClick += new System.EventHandler(this.tbBaseDirectory_DoubleClick);
            // 
            // lbBaseDirectory
            // 
            this.lbBaseDirectory.AutoSize = true;
            this.lbBaseDirectory.Location = new System.Drawing.Point(12, 396);
            this.lbBaseDirectory.Name = "lbBaseDirectory";
            this.lbBaseDirectory.Size = new System.Drawing.Size(92, 13);
            this.lbBaseDirectory.TabIndex = 3;
            this.lbBaseDirectory.Text = "Base Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tracks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artist Username";
            // 
            // clbTracks
            // 
            this.clbTracks.CheckOnClick = true;
            this.clbTracks.FormattingEnabled = true;
            this.clbTracks.Location = new System.Drawing.Point(15, 65);
            this.clbTracks.Name = "clbTracks";
            this.clbTracks.Size = new System.Drawing.Size(295, 292);
            this.clbTracks.TabIndex = 6;
            // 
            // bDownloadChecked
            // 
            this.bDownloadChecked.Location = new System.Drawing.Point(15, 364);
            this.bDownloadChecked.Name = "bDownloadChecked";
            this.bDownloadChecked.Size = new System.Drawing.Size(295, 23);
            this.bDownloadChecked.TabIndex = 7;
            this.bDownloadChecked.Text = "Download Checked";
            this.bDownloadChecked.UseVisualStyleBackColor = true;
            this.bDownloadChecked.Click += new System.EventHandler(this.bDownloadChecked_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 447);
            this.Controls.Add(this.bDownloadChecked);
            this.Controls.Add(this.clbTracks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBaseDirectory);
            this.Controls.Add(this.tbBaseDirectory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bGetTracks);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGetTracks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbBaseDirectory;
        private System.Windows.Forms.Label lbBaseDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbTracks;
        private System.Windows.Forms.Button bDownloadChecked;
    }
}