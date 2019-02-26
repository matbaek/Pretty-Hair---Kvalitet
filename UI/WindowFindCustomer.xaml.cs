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
    /// Interaction logic for WindowFindCustomer.xaml
    /// </summary>
    public partial class WindowFindCustomer : Window
    {
        public WindowFindCustomer()
        {
            InitializeComponent();
        }


        private void ButtonFindCustomerCreateNew_Click(object sender, RoutedEventArgs e)
        {
            WindowCreateNewCustomer wcnc = new WindowCreateNewCustomer();
            wcnc.Show();
            Close();
        }

        private void ButtonFindCustomerBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
