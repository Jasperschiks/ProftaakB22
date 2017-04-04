using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakB22
{
    class Grondstof
    {
        public int GrondstofID { get; set; }
        public string Omschrijving { get; set; }
        public int Voorraad_Aantal { get; set; }

        public Grondstof(int grondstofID, string omschrijving, int voorraad_aantal)
        {
            this.GrondstofID = grondstofID;
            this.Omschrijving = omschrijving;
            this.Voorraad_Aantal = voorraad_aantal;
        }
    }
}
