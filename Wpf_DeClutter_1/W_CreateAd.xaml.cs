using System;
using System.Collections.Generic;
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
using Microsoft.Win32;

namespace Wpf_DeClutter_1
{
    public partial class W_CreateAd : Window
    {
        public W_CreateAd()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            string imagePath = Tbx_pImage.Text;
            string[] parts = imagePath.Split('\\');
            string imageName = parts[parts.Length - 1];

            string destPath = @"\Resources\Images\" + imageName;
            string currentDirectory = System.Environment.CurrentDirectory;
            if(currentDirectory.EndsWith("\\bin\\Debug"))
            {
                int index = currentDirectory.IndexOf("\\bin\\Debug");
                currentDirectory = currentDirectory.Substring(0, index);
            }
            File.Copy(imagePath, currentDirectory + destPath);

            Item new_item = new Item {
                pName = Tbx_pName.Text,
                pCategory = Cbx_pCategory.Text,
                pDesc = Tbx_pDesc.Text,
                pContact = Tbx_pContact.Text,
                pLocation = Tbx_pLocation.Text,
                pImage = imageName,
                pDate = DateTime.Now.ToShortDateString(),
                isDisabled = "Active"
            };
            MainWindow.items.Add(new_item);

            Tbx_pName.Text = String.Empty;
            Tbx_pDesc.Text = String.Empty;
            Tbx_pContact.Text = String.Empty;
            Tbx_pLocation.Text = String.Empty;
            Tbx_pImage.Text = String.Empty;

            MessageBox.Show("Advertisment successfully created.", "DeClutter");
            Visibility = Visibility.Hidden;
        }

        private void Btn_open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*";
            fileDialog.DefaultExt = ".jpeg";
            Nullable<bool> dialogOk = fileDialog.ShowDialog();

            if (dialogOk == true)
            {
                string sFilenames = "";

                foreach (string sFilename in fileDialog.FileNames)
                {
                    sFilenames += ";" + sFilename;
                }

                sFilenames = sFilenames.Substring(1);

                Tbx_pImage.Text = sFilenames;
            }
        } 
    }
}
