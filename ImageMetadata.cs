namespace AreYouAfraidOfTheDark
{
    public class ImageMetadata
    {
        public string Name { get; set; }
        public string Extention { get; set; }
        public int Brightness { get; set; }
        public BrightnessLabelType BrightnessLabel { get; set; }
        public string FileNameSuggestion => $"{Name}_{Brightness}_{BrightnessLabel}{Extention}";

        public enum BrightnessLabelType
        {
            Dark,
            Light
        }
    }
}