using System.Drawing;
using Microsoft.Extensions.Configuration;

namespace AreYouAfraidOfTheDark
{
    public class ImageProcessor
    {
        private readonly ImageWriter _writer;
        private readonly ImageReader _reader;
        private readonly ImageMetadataExtracter _extracter;

        public ImageProcessor(IConfiguration configuration)
        {
            var imgInPath = configuration.GetValue<string>("InPath");
            var imgOutPath = configuration.GetValue<string>("OutPath");
            var brightnessIndex = configuration.GetValue<int>("BrightnessIndex");

            _reader = new ImageReader(imgInPath);
            _writer = new ImageWriter(imgOutPath);
            _extracter = new ImageMetadataExtracter(brightnessIndex);
        }

        public void ProcessImagesParallel()
        {
            var images = _reader.GetFiles();

            images.AsParallel().ForAll(image =>
            {
                var metadata = _extracter.GetMetadata(image);
                _writer.Write(image, metadata);
            });
        }
    }
}