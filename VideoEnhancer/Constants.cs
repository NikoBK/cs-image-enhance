/*
    file: Constants.cs
    author: NikoBK
    created on: nov 24 2023
*/
using Emgu.CV.Structure;

namespace VideoEnhancer
{
    public static class Constants
    {
        // Threading
        public const int TPS = 25;
        public const int MSPerTick = 1000 / TPS;
        public const int UITimerInterval = 25;

        // Color Domains
        public static Dictionary<string, string[]> ColorDomains = new Dictionary<string, string[]>()
        {
            { "BGR", new string[]{ "Blue", "Green", "Red" } },
            { "RGB", new string[]{ "Red", "Green", "Blue" } },
            { "HSV", new string[]{ "Hue", "Saturation", "Value" } },
            { "LAB", new string[]{ "Lightness", "Alpha", "Beta" } },
            { "GRAY", new string[]{ "Gray", "", "" } }
        };

        // Gaussian Blur
        public const int DefaultGaussKernelSize = 3;
        public const int DefaultGaussSigmaY = 0;
    }
}
