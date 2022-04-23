using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using BarcodeLib;
using System.Drawing.Imaging;

namespace SoundStudio.Classes
{
    class BarcodeGeneration
    {
        DateTime date = DateTime.Now;
        public void barcodeGeneration(Barcode BW)
        {
            if (BW.barcodeTextBox.Text.Length == 0 || BW.barcodeTextBoxTwo.Text.Length == 0)
            {
                MessageBox.Show("Данные не введены!");
            }
            else
            {
                string gener = "51" + date.Day + date.Month + date.Year + "38";
                BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                System.Drawing.Image img = b.Encode(BarcodeLib.TYPE.UPCA, gener, System.Drawing.Color.Black, System.Drawing.Color.White, 290, 120);

                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);//save image in memory

                byte[] buffer = ms.GetBuffer();
                MemoryStream bufferPasser = new MemoryStream(buffer);
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = bufferPasser;
                bitmap.EndInit();
                BW.barcodeImage.Source = bitmap;
            }
        }
    }
}
