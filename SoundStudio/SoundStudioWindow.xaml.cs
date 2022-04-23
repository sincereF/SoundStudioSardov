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
//using BarcodeLib;
//using System.Drawing.Imaging;

namespace SoundStudio
{
    /// <summary>
    /// Логика взаимодействия для SoundStudioWindow.xaml
    /// </summary>
    public partial class SoundStudioWindow : Window
    {
        public SoundStudioWindow()
        {
            InitializeComponent();
            homePageBorder.Visibility = Visibility.Visible;
            homePageImage.Visibility = Visibility.Visible;
        }

        private void soundStudioBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void soundStudioCloseButton_Click(object sender, RoutedEventArgs e)
        {
            base.OnClosed(e);
            App.Current.Shutdown();
        }

        private void soundStudioExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwin = new MainWindow();
            mwin.Show();
            this.Close();
        }

        private void aboutUsButton_Click(object sender, RoutedEventArgs e)
        {
            contactsBorder.Visibility = Visibility.Hidden;
            contactsLabelOne.Visibility = Visibility.Hidden;
            contactsLabelTwo.Visibility = Visibility.Hidden;
            contactsLabelThree.Visibility = Visibility.Hidden;
            contactsLabelFour.Visibility = Visibility.Hidden;
            instImage.Visibility = Visibility.Hidden;
            vkImage.Visibility = Visibility.Hidden;
            contactsLabelImage.Visibility = Visibility.Hidden;

            homePageBorder.Visibility = Visibility.Hidden;
            homePageImage.Visibility = Visibility.Hidden;

            productsListView.Visibility = Visibility.Hidden;
            productsInfoLabel.Visibility = Visibility.Hidden;

            servicesListView.Visibility = Visibility.Hidden;
            inBasketButton.Visibility = Visibility.Hidden;

            costBasketListView.Visibility = Visibility.Hidden;
            inBasketDeleteButton.Visibility = Visibility.Hidden;
            costLabel.Visibility = Visibility.Hidden;
            paymentReceiptButton.Visibility = Visibility.Hidden;

            aboutUsBorder.Visibility = Visibility.Visible;
            aboutUsLabelOne.Visibility = Visibility.Visible;
            aboutUsLabelTwo.Visibility = Visibility.Visible;
            aboutUsLabelThree.Visibility = Visibility.Visible;
            aboutUsLabelFour.Visibility = Visibility.Visible;
            aboutUsLabelFive.Visibility = Visibility.Visible;
            aboutUsLabelSix.Visibility = Visibility.Visible;
            aboutUsLabelSeven.Visibility = Visibility.Visible;
            aboutUsLabelEight.Visibility = Visibility.Visible;
            aboutUsLabelNine.Visibility = Visibility.Visible;

        }

        private void contactsButton_Click(object sender, RoutedEventArgs e)
        {
            aboutUsBorder.Visibility = Visibility.Hidden;
            aboutUsLabelOne.Visibility = Visibility.Hidden;
            aboutUsLabelTwo.Visibility = Visibility.Hidden;
            aboutUsLabelThree.Visibility = Visibility.Hidden;
            aboutUsLabelFour.Visibility = Visibility.Hidden;
            aboutUsLabelFive.Visibility = Visibility.Hidden;
            aboutUsLabelSix.Visibility = Visibility.Hidden;
            aboutUsLabelSeven.Visibility = Visibility.Hidden;
            aboutUsLabelEight.Visibility = Visibility.Hidden;
            aboutUsLabelNine.Visibility = Visibility.Hidden;

            homePageBorder.Visibility = Visibility.Hidden;
            homePageImage.Visibility = Visibility.Hidden;

            productsListView.Visibility = Visibility.Hidden;
            productsInfoLabel.Visibility = Visibility.Hidden;

            servicesListView.Visibility = Visibility.Hidden;
            inBasketButton.Visibility = Visibility.Hidden;

            costBasketListView.Visibility = Visibility.Hidden;
            inBasketDeleteButton.Visibility = Visibility.Hidden;
            costLabel.Visibility = Visibility.Hidden;
            paymentReceiptButton.Visibility = Visibility.Hidden;

            contactsBorder.Visibility = Visibility.Visible;
            contactsLabelOne.Visibility = Visibility.Visible;
            contactsLabelTwo.Visibility = Visibility.Visible;
            contactsLabelThree.Visibility = Visibility.Visible;
            contactsLabelFour.Visibility = Visibility.Visible;
            instImage.Visibility = Visibility.Visible;
            vkImage.Visibility = Visibility.Visible;
            contactsLabelImage.Visibility = Visibility.Visible;
        }

        private void homePageButton_Click(object sender, RoutedEventArgs e)
        {
            aboutUsBorder.Visibility = Visibility.Hidden;
            aboutUsLabelOne.Visibility = Visibility.Hidden;
            aboutUsLabelTwo.Visibility = Visibility.Hidden;
            aboutUsLabelThree.Visibility = Visibility.Hidden;
            aboutUsLabelFour.Visibility = Visibility.Hidden;
            aboutUsLabelFive.Visibility = Visibility.Hidden;
            aboutUsLabelSix.Visibility = Visibility.Hidden;
            aboutUsLabelSeven.Visibility = Visibility.Hidden;
            aboutUsLabelEight.Visibility = Visibility.Hidden;
            aboutUsLabelNine.Visibility = Visibility.Hidden;

            contactsBorder.Visibility = Visibility.Hidden;
            contactsLabelOne.Visibility = Visibility.Hidden;
            contactsLabelTwo.Visibility = Visibility.Hidden;
            contactsLabelThree.Visibility = Visibility.Hidden;
            contactsLabelFour.Visibility = Visibility.Hidden;
            instImage.Visibility = Visibility.Hidden;
            vkImage.Visibility = Visibility.Hidden;
            contactsLabelImage.Visibility = Visibility.Hidden;

            productsListView.Visibility = Visibility.Hidden;
            productsInfoLabel.Visibility = Visibility.Hidden;

            servicesListView.Visibility = Visibility.Hidden;
            inBasketButton.Visibility = Visibility.Hidden;

            costBasketListView.Visibility = Visibility.Hidden;
            inBasketDeleteButton.Visibility = Visibility.Hidden;
            costLabel.Visibility = Visibility.Hidden;
            paymentReceiptButton.Visibility = Visibility.Hidden;

            homePageBorder.Visibility = Visibility.Visible;
            homePageImage.Visibility = Visibility.Visible;
        }

        private void productsButton_Click(object sender, RoutedEventArgs e)
        {
            homePageBorder.Visibility = Visibility.Hidden;
            homePageImage.Visibility = Visibility.Hidden;

            aboutUsBorder.Visibility = Visibility.Hidden;
            aboutUsLabelOne.Visibility = Visibility.Hidden;
            aboutUsLabelTwo.Visibility = Visibility.Hidden;
            aboutUsLabelThree.Visibility = Visibility.Hidden;
            aboutUsLabelFour.Visibility = Visibility.Hidden;
            aboutUsLabelFive.Visibility = Visibility.Hidden;
            aboutUsLabelSix.Visibility = Visibility.Hidden;
            aboutUsLabelSeven.Visibility = Visibility.Hidden;
            aboutUsLabelEight.Visibility = Visibility.Hidden;
            aboutUsLabelNine.Visibility = Visibility.Hidden;

            contactsBorder.Visibility = Visibility.Hidden;
            contactsLabelOne.Visibility = Visibility.Hidden;
            contactsLabelTwo.Visibility = Visibility.Hidden;
            contactsLabelThree.Visibility = Visibility.Hidden;
            contactsLabelFour.Visibility = Visibility.Hidden;
            instImage.Visibility = Visibility.Hidden;
            vkImage.Visibility = Visibility.Hidden;
            contactsLabelImage.Visibility = Visibility.Hidden;

            servicesListView.Visibility = Visibility.Hidden;
            inBasketButton.Visibility = Visibility.Hidden;

            costBasketListView.Visibility = Visibility.Hidden;
            inBasketDeleteButton.Visibility = Visibility.Hidden;
            costLabel.Visibility = Visibility.Hidden;
            paymentReceiptButton.Visibility = Visibility.Hidden;

            productsListView.Visibility = Visibility.Visible;
            productsInfoLabel.Visibility = Visibility.Visible;
            productsListView.Items.Clear();
            Classes.LoadProducts loadProducts = new Classes.LoadProducts();
            loadProducts.loadProducts(this);
        }

        private void servicesButton_Click(object sender, RoutedEventArgs e)
        {
            homePageBorder.Visibility = Visibility.Hidden;
            homePageImage.Visibility = Visibility.Hidden;

            aboutUsBorder.Visibility = Visibility.Hidden;
            aboutUsLabelOne.Visibility = Visibility.Hidden;
            aboutUsLabelTwo.Visibility = Visibility.Hidden;
            aboutUsLabelThree.Visibility = Visibility.Hidden;
            aboutUsLabelFour.Visibility = Visibility.Hidden;
            aboutUsLabelFive.Visibility = Visibility.Hidden;
            aboutUsLabelSix.Visibility = Visibility.Hidden;
            aboutUsLabelSeven.Visibility = Visibility.Hidden;
            aboutUsLabelEight.Visibility = Visibility.Hidden;
            aboutUsLabelNine.Visibility = Visibility.Hidden;

            contactsBorder.Visibility = Visibility.Hidden;
            contactsLabelOne.Visibility = Visibility.Hidden;
            contactsLabelTwo.Visibility = Visibility.Hidden;
            contactsLabelThree.Visibility = Visibility.Hidden;
            contactsLabelFour.Visibility = Visibility.Hidden;
            instImage.Visibility = Visibility.Hidden;
            vkImage.Visibility = Visibility.Hidden;
            contactsLabelImage.Visibility = Visibility.Hidden;

            productsListView.Visibility = Visibility.Hidden;
            productsInfoLabel.Visibility = Visibility.Hidden;

            costBasketListView.Visibility = Visibility.Hidden;
            inBasketDeleteButton.Visibility = Visibility.Hidden;
            costLabel.Visibility = Visibility.Hidden;
            paymentReceiptButton.Visibility = Visibility.Hidden;

            servicesListView.Visibility = Visibility.Visible;
            inBasketButton.Visibility = Visibility.Visible;
            servicesListView.Items.Clear();
            Classes.LoadServices loadServices = new Classes.LoadServices();
            loadServices.loadServices(this);
        }

        private void costBasketButton_Click(object sender, RoutedEventArgs e)
        {
            homePageBorder.Visibility = Visibility.Hidden;
            homePageImage.Visibility = Visibility.Hidden;

            aboutUsBorder.Visibility = Visibility.Hidden;
            aboutUsLabelOne.Visibility = Visibility.Hidden;
            aboutUsLabelTwo.Visibility = Visibility.Hidden;
            aboutUsLabelThree.Visibility = Visibility.Hidden;
            aboutUsLabelFour.Visibility = Visibility.Hidden;
            aboutUsLabelFive.Visibility = Visibility.Hidden;
            aboutUsLabelSix.Visibility = Visibility.Hidden;
            aboutUsLabelSeven.Visibility = Visibility.Hidden;
            aboutUsLabelEight.Visibility = Visibility.Hidden;
            aboutUsLabelNine.Visibility = Visibility.Hidden;

            contactsBorder.Visibility = Visibility.Hidden;
            contactsLabelOne.Visibility = Visibility.Hidden;
            contactsLabelTwo.Visibility = Visibility.Hidden;
            contactsLabelThree.Visibility = Visibility.Hidden;
            contactsLabelFour.Visibility = Visibility.Hidden;
            instImage.Visibility = Visibility.Hidden;
            vkImage.Visibility = Visibility.Hidden;
            contactsLabelImage.Visibility = Visibility.Hidden;

            productsListView.Visibility = Visibility.Hidden;
            productsInfoLabel.Visibility = Visibility.Hidden;

            servicesListView.Visibility = Visibility.Hidden;
            inBasketButton.Visibility = Visibility.Hidden;

            costBasketListView.Visibility = Visibility.Visible;
            inBasketDeleteButton.Visibility = Visibility.Visible;
            costLabel.Visibility = Visibility.Visible;
            paymentReceiptButton.Visibility = Visibility.Visible;
        }

        private void inBasketButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Сalculation сalculation = new Classes.Сalculation();
            сalculation.calculationCostServices(this);
        }

        private void inBasketDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Сalculation сalculation = new Classes.Сalculation();
            сalculation.calculationCostDelete(this);
        }

        private void paymentReceiptButton_Click(object sender, RoutedEventArgs e)
        {
            Barcode barcodeWin = new Barcode();
            barcodeWin.Owner = SoundStudioWin;
            barcodeWin.Show();
        }
    }
}
