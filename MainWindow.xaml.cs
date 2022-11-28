using sbWpnActiveX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WMPLib;

namespace PocSBSS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SBSSActivX activX = new SBSSActivX();
        public MainWindow()
        {
            InitializeComponent();
            TextBox1.Text = "Not Connected";
            activX.init();
        }

        private void ConnexionButton_Click(object sender, RoutedEventArgs e)
        {
            activX.connect();
            if (activX.get().Connected)
            {
                TextBox1.Text = "Connected";
            }
        }
    }
}
