using System.Drawing;
using System.IO;

namespace AreYouAfraidOfTheDark
{
    public class ImageReader
    {
        private readonly DirectoryInfo _imageDir;

        public ImageReader(string imageDir)
        {
            _imageDir = new DirectoryInfo(imageDir);
        }

        public IEnumerable<FileInfo> GetFiles() => _imageDir.GetFiles();
    }
}