# Csharp Underwater Image Enhancement
This application was developed as a educational project that aimed to improve underwater image enhancement for danish marine terrain recordings.
The goal was to use OpenCV in C# to get performance and faster image processing on a video recording. This application attempts to provide live customizable
video enhancement with a comparison between the input recording and the output (post-processed) with a menu of algorithms and adjustments to pick
from to alter and modify the recording.

The application can view the input recording in different color spaces as well as channels, take screenshots and compare specific frames between
input and processed recording frames at any given time.

## Disclaimer
The project is largely still unfinished because it failed to fully achieve the performance requirements set by the authoring group I was part of.
The project remains public on Github to inspire developers looking into the same field of C# image enhancement even though my personal recommendation
would be C++ for future projects where building OpenCV and directly integrating it into the project is possible.

## Dependencies (Important)
When this project was last worked on it used `Magick.NET-Q8-AnyCPU (13.4.0)` **which has a vulnerability with high severity**. Please update it as soon as possible if you decide to run this code.

NuGet packages:
- Emgu.CV (4.8.1.5350), Emgu Corporation
- Emgu.CV.Bitmap (4.8.1.5350), Emgu Corporation
- Emgu.CV.runtime.windows (4.8.1.5350), Emgu Corporation
- Magick.NET-Q8-AnyCPU (13.4.0 ⚠️), Dirk Lemstra

The project is written in plain .NET Core 6.0 for Windows.
