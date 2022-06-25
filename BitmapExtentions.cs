using System.Drawing;

namespace AreYouAfraidOfTheDark
{
    public static class BitmapExtentions
    {
        public static int GetBrightness(this Bitmap btm)
        {
            var data = new List<double>();

            for (int x = 0; x < btm.Width; x++)
            {
                for (int y = 0; y < btm.Height; y++)
                {
                    var pixelColor = btm.GetPixel(x, y);
                    var brightness = pixelColor.GetBrightness();

                    data.Add(brightness);
                }
            }

            data.Sort();

            var average = data.Average();
            var median = data[data.Count() / 2];
            var midleValue = (average + median) / 2 * 100;

            return (int)Math.Round(midleValue);
        }
    }
}