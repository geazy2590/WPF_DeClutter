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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_DeClutter_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       //string query = "";
        public static ObservableCollection<Item> items;
        public static ObservableCollection<Item> itemsToDisp;

        public static List<string> categories = new List<string>
        {
            "Clothing", "Electronics", "Furniture", "Kitchenware", "Miscellaneous"
        };
        public static ItemContainer itemContainer; 


        public MainWindow()
        {
            var it = new ObservableCollection<Item>();
            InitializeComponent();
            itemContainer = Storage.ReadXml<ItemContainer>("file.xml");
            items = itemContainer.Items;
            itemsToDisp = items;
            var results = new ObservableCollection<Item>(from s in itemsToDisp where s.isDisabled == "Active" select s);
            Grd_items.ItemsSource = results;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_categories.ItemsSource = categories;
        }

        private void createAd(object sender, RoutedEventArgs e)
        {
            W_CreateAd ad = new W_CreateAd();
            ad.Show();
        }

        private void gotoAd(object sender, RoutedEventArgs e)
        {
            W_GoToAd eachAd = new W_GoToAd((Item)Grd_items.SelectedItem);
            eachAd.Show();
        }

        private void myAds(object sender, RoutedEventArgs e)
        {
            W_MyAds myAd = new W_MyAds(items) { DataContext = this };
            myAd.Show();
        }

        private void Tbx_category_Changed(object sender, TextChangedEventArgs e)
        {
            string query = Tbx_items_filter.Text;

            if (string.IsNullOrEmpty(query))
            {
                Grd_items.ItemsSource = items;
                return;
            }

            var results = new ObservableCollection<Item>(from s in items where s.pName.Contains(query) select s);
            Grd_items.ItemsSource = results;
        }

        private void Tbx_items_Changed(object sender, TextChangedEventArgs e)
        {
            string query = Tbx_category_filter.Text;

            if (string.IsNullOrEmpty(query))
            {
                Lbx_categories.ItemsSource = categories;
                var results1 = new ObservableCollection<Item>(from s in itemsToDisp where s.isDisabled == "Active" select s);
                Grd_items.ItemsSource = results1;
                return;
            }

            var results = from s in categories where s.Contains(query) select s;
            Lbx_categories.ItemsSource = results;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ItemContainer itemC = new ItemContainer() { Items = items };
            Storage.WriteXml<ItemContainer>(itemC, "file.xml");
        }

        private void Lbx_filter_items(object sender, MouseButtonEventArgs e)
        {
            string query = (string)Lbx_categories.SelectedItem;
            if (string.IsNullOrEmpty(query))
            {
                Lbx_categories.ItemsSource = categories;
                return;
            }
            Tbx_category_filter.Text = query;
            var results = from s in categories where s.Contains(query) select s;
            Lbx_categories.ItemsSource = results;
            var resultsItem = new ObservableCollection<Item>(from i in items where i.pCategory.Contains(query) select i);
            Grd_items.ItemsSource = resultsItem;
        }

        private void Btn_clear_filter(object sender, RoutedEventArgs e)
        {
            Tbx_category_filter.Text = String.Empty;
        }
    }

    public class ItemContainer
    {
        public ObservableCollection<Item> Items { get; set; }
    }
}
