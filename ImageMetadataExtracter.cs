using System.Drawing;

namespace AreYouAfraidOfTheDark
{
    public class ImageMetadataExtracter
    {
        private readonly int _brightnessIndex;

        public ImageMetadataExtracter(int brightnessIndex) => _brightnessIndex = brightnessIndex;

        public ImageMetadata GetMetadata(FileInfo file)
        {
            var name = file.Name;
            var extention = file.Extension;
            var brightness = new Bitmap(file.FullName).GetBrightness();
            var type = brightness >= 22 ? ImageMetadata.BrightnessLabelType.Light : ImageMetadata.BrightnessLabelType.Dark;

            return new ImageMetadata
            {
                Name = Path.GetFileNameWithoutExtension(name),
                Extention = extention,
                Brightness = brightness,
                BrightnessLabel = type
            };
        }
    }
}