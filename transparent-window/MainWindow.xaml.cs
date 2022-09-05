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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace transparent_window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            topBorder.Opacity = 0;
            bottomBorder.Opacity = 0;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            topBorder.Opacity = 100;
            bottomBorder.Opacity = 100;
        }

        private void menuItemActive_Click(object sender, RoutedEventArgs e)
        {
            this.Activate();
        }

        private void menuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
