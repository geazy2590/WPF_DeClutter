using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_DeClutter_1
{
    /// <summary>
    /// Interaction logic for W_MyAds.xaml
    /// </summary>
    public partial class W_MyAds : Window
    {
        ObservableCollection<Item> it;

        public static string currentUser = "asda";

        private MainWindow mainWindow;

        public W_MyAds(ObservableCollection<Item> items)
        {
            InitializeComponent();
            this.it = items;
            var results = from s in it where s.pCreatedBy == currentUser select s;
            Grd_items.ItemsSource = results;
        }

        private void gotoAd(object sender, MouseButtonEventArgs e)
        {
            W_GoToAd eachAd = new W_GoToAd((Item)Grd_items.SelectedItem);
            eachAd.Show();
        }

        private void Btn_change_status(object sender, RoutedEventArgs e)
        {
            //if ((Item)Grd_items.SelectedItem != null)
            //{
                if ((((Item)Grd_items.SelectedItem).isDisabled).Equals("Active"))
                {
                    ((Item)Grd_items.SelectedItem).isDisabled = "Inactive";
                    ((ObservableCollection<Item>)mainWindow.Grd_items.ItemsSource).Remove((Item)Grd_items.SelectedItem);
                }
                else
                {
                    (((Item)Grd_items.SelectedItem).isDisabled) = "Active";
                    ((ObservableCollection<Item>)mainWindow.Grd_items.ItemsSource).Add((Item)Grd_items.SelectedItem);
                }
            //}
           
        }


        private void W_MyAds1_Loaded(object sender, RoutedEventArgs e)
        {
            mainWindow = (MainWindow)this.DataContext;
        }
    }
}
