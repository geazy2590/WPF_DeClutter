using System;
using System.Collections.Generic;
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
    /// Interaction logic for W_GoToAd.xaml
    /// </summary>
    public partial class W_GoToAd : Window
    {
        public Item item { get; set; }
     
        public W_GoToAd (Item it)
        {
            InitializeComponent();
            this.item = it;
            Tbk_name.Text = this.item.pName;
            Tbk_heading.Text = this.item.pName;
            Tbk_desc.Text = this.item.pDesc;
            Tbk_loc.Text = this.item.pLocation;
            Tbk_postOn.Text = this.item.pDate;
            Tbk_email.Text = this.item.pContact;
            this.DataContext = this;
        }

        private void createAd(object sender, RoutedEventArgs e)
        {

        }

        private void myAds(object sender, RoutedEventArgs e)
        {

        }
    }
}
