using System.IO;
using System.Text;

namespace ScrapeTrain.Core.Helpers
{
    public static class SanitizeHelper
    {
        private const string AdditionalIllegalCharacters
            = "\\/:*?\"<>|";

        private static readonly char[] FileEscapeCharacters;
        private static readonly char[] PathEscapeCharacters;

        static SanitizeHelper()
        {
            var escapeBuilder = new StringBuilder();
            escapeBuilder.Append(AdditionalIllegalCharacters);
            escapeBuilder.Append(Path.GetInvalidFileNameChars());
            FileEscapeCharacters = escapeBuilder.ToString().ToCharArray();

            escapeBuilder = new StringBuilder();
            escapeBuilder.Append(AdditionalIllegalCharacters);
            escapeBuilder.Append(Path.GetInvalidPathChars());
            PathEscapeCharacters = escapeBuilder.ToString().ToCharArray();
        }

        public static string ForFileName(string fileName)
        {
            return string.Concat(fileName.Split(FileEscapeCharacters));
        }

        public static string ForPath(string path)
        {
            var result = string.Concat(path.Split(PathEscapeCharacters));

            if (result.EndsWith("."))
                result = result.Substring(0, result.Length - 1);

            return result;
        }
    }
}
