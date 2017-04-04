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
using System.Data.SqlClient;

namespace ProftaakB22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=DESKTOP-K7MLI2P\SQLEXPRESS;Initial Catalog=ProftaakB22;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //    con.ConnectionString = "Server=DESKTOP-K7MLI2P/SQLEXPRESS;Database=ProftaakB22;integrated security = SSPI;Trusted_Connection=true ";
            //    try
            //    {
            //        //        con.Open();
            //        MessageBox.Show("Connection");

            //    }
            //    catch (SqlException)
            //    {
            //        MessageBox.Show("error");
            //    }
            //    using (SqlCommand command = new SqlCommand("CREATE TABLE Customer(First_Name char(50),Last_Name char(50),Address char(50),City char(50),Country char(25),Birth_Date datetime);", con))
            //        command.ExecuteNonQuery();
            //
        }

        private void Btn_Inkoop_Click(object sender, RoutedEventArgs e)
        {
            Inkoop ink = new Inkoop();
            ink.Show();
            this.Close();
        }

        private void Btn_Voorraad_Click(object sender, RoutedEventArgs e)
        {
            Voorraad vor = new Voorraad();
            vor.Show();
            this.Close();
        }
    }
}
