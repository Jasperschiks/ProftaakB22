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

namespace ProftaakB22
{
    /// <summary>
    /// Interaction logic for Inkoop.xaml
    /// </summary>
    public partial class Inkoop : Window
    {
        InkoopDB admin = new InkoopDB();
        public Inkoop()
        {

            InitializeComponent();
          

        }

        private void Btn_NieuweOrder_Click(object sender, RoutedEventArgs e)
        {
         
            
        }
    }
}
