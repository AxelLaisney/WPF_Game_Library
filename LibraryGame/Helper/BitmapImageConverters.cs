using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace LibraryGame.Helper
{
    public class BitmapImageConverters
    {
        public string BitmapimageToBase64(BitmapImage img)
        {
            byte[] bytesArray;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(img));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                bytesArray = ms.ToArray();
                String byteToBase64 = Convert.ToBase64String(bytesArray);
                return byteToBase64;
            }
        }

        public BitmapImage Base64ToBitmapimage(string imgString)
        {
            byte[] binaryData = Convert.FromBase64String(imgString);

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(binaryData);
            bi.EndInit();

            return bi;
        }
    }
}
