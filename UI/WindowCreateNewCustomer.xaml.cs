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
    /// Interaction logic for WindowCreateNewCustomer.xaml
    /// </summary>
    public partial class WindowCreateNewCustomer : Window
    {
        public WindowCreateNewCustomer()
        {
            InitializeComponent();
        }

        private void ButtonCreateNewCustomerBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
