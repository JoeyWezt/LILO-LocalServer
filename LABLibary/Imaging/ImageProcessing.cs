﻿/*

        Copyright© 2023 Joe Valentino Lengefeld

        Licensed under the Apache License, Version 2.0 (the "License");
        you may not use this file except in compliance with the License.
        You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
        Unless required by applicable law or agreed to in writing, software
        distributed under the License is distributed on an "AS IS" BASIS,
        WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
        See the License for the specific language governing permissions and
        limitations under the License.

        Last edit : 02.04.2023
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace LABLibary.Imaging;
public class ImageProcessing
{
    public class Templates
    {
        public Bitmap source;

        public Templates(Bitmap sourceImage)
        {
            this.source = sourceImage;   
        }

        public Bitmap BlurredImage()
        {
            ScaleFilter scale = new ScaleFilter(0.1f);
            BlurFilter blur = new BlurFilter(60);
            DarkenFilter darker = new DarkenFilter(0.5f);

            Bitmap scaledPic = scale.ApplyFilter(source);
            Bitmap blurredPic = blur.ApplyFilter(scaledPic);
            Bitmap finalPic = darker.ApplyFilter(blurredPic);
            return finalPic;

        }
    }

    public class ColorManagment
    {
        public class ColorDetector
        {
            public Bitmap image;

            public ColorDetector(Bitmap sourceImage)
            {
               this.image = sourceImage;
            }

            public Color DetectMainColor()
            {
                // Create a dictionary to store the count of each color
                Dictionary<Color, int> colorCounts = new Dictionary<Color, int>();

                // Loop through each pixel in the image
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        // Get the color of the pixel
                        Color pixelColor = image.GetPixel(x, y);

                        // Add the color to the dictionary or increment the count if it already exists
                        if (colorCounts.ContainsKey(pixelColor))
                        {
                            colorCounts[pixelColor]++;
                        }
                        else
                        {
                            colorCounts[pixelColor] = 1;
                        }
                    }
                }

                // Find the color with the highest count
                Color mainColor = Color.Black;
                int maxCount = 0;
                foreach (KeyValuePair<Color, int> colorCount in colorCounts)
                {
                    if (colorCount.Value > maxCount)
                    {
                        mainColor = colorCount.Key;
                        maxCount = colorCount.Value;
                    }
                }

                return mainColor;
            }

            public Color GetOppositeColor(Color color)
            {
                // Calculate the opposite color by subtracting each component from 255
                int red = 255 - color.R;
                int green = 255 - color.G;
                int blue = 255 - color.B;

                return Color.FromArgb(red, green, blue);
            }
        }
    }

    public class BlurFilter
    {
        // The size of the blur kernel
        private int kernelSize;

        public BlurFilter(int kernelSize)
        {
            this.kernelSize = kernelSize;
        }

        public Bitmap ApplyFilter(Bitmap sourceImage)
        {
            // Create a new bitmap to store the output image
            Bitmap outputImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            // Loop through each pixel in the image
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    // Calculate the average color of the surrounding pixels
                    int red = 0, green = 0, blue = 0;
                    int count = 0;
                    for (int i = -kernelSize / 2; i <= kernelSize / 2; i++)
                    {
                        for (int j = -kernelSize / 2; j <= kernelSize / 2; j++)
                        {
                            // Check if the pixel is within the bounds of the image
                            if (x + i >= 0 && x + i < sourceImage.Width && y + j >= 0 && y + j < sourceImage.Height)
                            {
                                Color pixelColor = sourceImage.GetPixel(x + i, y + j);
                                red += pixelColor.R;
                                green += pixelColor.G;
                                blue += pixelColor.B;
                                count++;
                            }
                        }
                    }

                    // Calculate the average values
                    red /= count;
                    green /= count;
                    blue /= count;

                    // Set the pixel in the output image to the average color
                    outputImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return outputImage;
        }
    }

    public class ScaleFilter
    {
        // The scale factor for the image
        private float scaleFactor;

        public ScaleFilter(float scaleFactor)
        {
            this.scaleFactor = scaleFactor;
        }

        public Bitmap ApplyFilter(Bitmap sourceImage)
        {
            // Calculate the new width and height of the image
            int newWidth = (int)(sourceImage.Width * scaleFactor);
            int newHeight = (int)(sourceImage.Height * scaleFactor);

            // Create a new bitmap to store the output image
            Bitmap outputImage = new Bitmap(newWidth, newHeight);

            // Create a graphics object to draw on the output image
            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                // Set the interpolation mode to high quality
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the source image onto the output image, scaling it to the new size
                graphics.DrawImage(sourceImage, 0, 0, newWidth, newHeight);
            }

            return outputImage;
        }
    }

    public class Image
    {
        public static Bitmap ResizeImage(Bitmap originalImage, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using var graphics = Graphics.FromImage(resizedImage);
            graphics.DrawImage(originalImage, new Rectangle(0, 0, width, height), new Rectangle(0, 0, originalImage.Width, originalImage.Height), GraphicsUnit.Pixel);
            return resizedImage;
        }

        public static Bitmap CropImage(Bitmap originalImage, int x, int y, int width, int height)
        {
            var croppedImage = new Bitmap(width, height);
            using var graphics = Graphics.FromImage(croppedImage);
            graphics.DrawImage(originalImage, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
            return croppedImage;
        }

        public static Bitmap RotateImage(Bitmap originalImage, float angle)
        {
            var rotatedImage = new Bitmap(originalImage.Width, originalImage.Height);
            using var graphics = Graphics.FromImage(rotatedImage);
            graphics.TranslateTransform((float)originalImage.Width / 2, (float)originalImage.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)originalImage.Width / 2, -(float)originalImage.Height / 2);
            graphics.DrawImage(originalImage, new Point(0, 0));
            return rotatedImage;
        }
    }

    public class DarkenFilter
    {
        // The amount to darken the image (between 0 and 1)
        private float darknessAmount;

        public DarkenFilter(float darknessAmount)
        {
            this.darknessAmount = darknessAmount;
        }

        public Bitmap ApplyFilter(Bitmap sourceImage)
        {
            // Create a new bitmap to store the output image
            Bitmap outputImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            // Loop through each pixel in the image
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    // Get the color of the pixel
                    Color pixelColor = sourceImage.GetPixel(x, y);

                    // Darken the pixel
                    int red = (int)(pixelColor.R * darknessAmount);
                    int green = (int)(pixelColor.G * darknessAmount);
                    int blue = (int)(pixelColor.B * darknessAmount);

                    // Set the pixel in the output image to the darkened color
                    outputImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return outputImage;
        }
    }
}
