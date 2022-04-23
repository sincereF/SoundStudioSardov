using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;



namespace SoundStudio.Classes
{
    class Сalculation
    {
        int sum = 0;
        public void calculationCostServices(SoundStudioWindow SSW)
        {          
            int iz = 0;
            

            iz = SSW.servicesListView.SelectedIndex;
            if (iz >= 0)
            {
                var selectedItem = (dynamic)SSW.servicesListView.Items[iz];
                SSW.costBasketListView.Items.Add(selectedItem);
            }

            for (int i = 0; i < SSW.costBasketListView.Items.Count; i++)
            {
                var selectedItem = (dynamic)SSW.costBasketListView.Items[i];
                sum += Convert.ToInt32(selectedItem.costServices);
                SSW.costLabel.Content = "Итого к оплате: " + sum.ToString();
            }
        }

        public void calculationCostDelete(SoundStudioWindow SSW)
        {
            if (SSW.costBasketListView.SelectedItem != null)
            {
                SSW.costBasketListView.Items.RemoveAt(SSW.costBasketListView.Items.IndexOf(SSW.costBasketListView.SelectedItem));
            }

            for (int i = 0; i < SSW.costBasketListView.Items.Count; i++)
            {
                var selectedItem = (dynamic)SSW.costBasketListView.Items[i];
                sum += Convert.ToInt32(selectedItem.costServices);
                SSW.costLabel.Content = "Итого к оплате: " + sum.ToString();
            }

            if (sum == 0)
            {
                SSW.costLabel.Content = "Итого к оплате: 0";
            }
        }
    }
}
