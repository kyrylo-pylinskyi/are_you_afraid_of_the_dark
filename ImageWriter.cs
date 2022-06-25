using System.Drawing;
using System.Drawing.Imaging;

namespace AreYouAfraidOfTheDark
{
    public class ImageWriter
    {
        private readonly string _outDir;

        public ImageWriter(string imgOutPath)
        {
            _outDir = imgOutPath;
        }

        public void Write(FileInfo file, ImageMetadata metadata)
        {
            var path = Path.Join(_outDir, metadata.FileNameSuggestion);
            file.CopyTo(path);
        }
    }
}