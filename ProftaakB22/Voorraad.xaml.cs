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
    /// Interaction logic for Voorraad.xaml
    /// </summary>
    public partial class Voorraad : Window
    {
        InkoopDB admin = new InkoopDB();
        public Voorraad()
        {

            InitializeComponent();
            List<Grondstof> grondstoffen = admin.Getgrondstoffen();
            // LV_InkoopOrders.ClearValue();
            foreach (Grondstof g in grondstoffen)
            {
                string grondstof = g.GrondstofID + g.Omschrijving + g.Voorraad_Aantal;
                LV_Voorraad.Items.Add(grondstof);
            }
        }
    }
}
