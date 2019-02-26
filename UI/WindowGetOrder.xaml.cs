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

namespace Pretty_Hair___Kvalitet
{
    /// <summary>
    /// Interaction logic for WindowGetOrder.xaml
    /// </summary>
    public partial class WindowGetOrder : Window
    {
        public WindowGetOrder()
        {
            InitializeComponent();
        }

        private void ButtonGetOrderBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
