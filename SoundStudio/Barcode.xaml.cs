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

namespace SoundStudio
{
    /// <summary>
    /// Логика взаимодействия для Barcode.xaml
    /// </summary>
    public partial class Barcode : Window
    {
        public Barcode()
        {
            InitializeComponent();
        }

        private void barcodeButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.BarcodeGeneration barcodeGen = new Classes.BarcodeGeneration();
            barcodeGen.barcodeGeneration(this);
        }

        private void barcodeCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void barcodeWindowBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
