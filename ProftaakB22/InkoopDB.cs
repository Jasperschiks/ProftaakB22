using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProftaakB22
{
    class InkoopDB
    {
        DBConnection dbcon = new DBConnection();
        private List<Grondstof> Grondstoffen = new List<Grondstof>();

        public InkoopDB()     
        {
            dbcon = new DBConnection();
        }

        public List<Grondstof> Getgrondstoffen()
        {
            Grondstoffen.Clear();
            string newsql = "SELECT * FROM Grondstof";  
            SqlCommand cmd = new SqlCommand(newsql, dbcon.Connection);
            dbcon.OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int GrondstofID = reader.GetInt32(0);  
                    string Omschrijving = reader.GetString(1);
                    int Vooraad_Aantal = reader.GetInt32(2);
                    Grondstof grnd = new Grondstof(GrondstofID, Omschrijving, Vooraad_Aantal);
                    Grondstoffen.Add(grnd);
                }
                dbcon.CloseConnection();
                return Grondstoffen;
            }
            else
            {
                dbcon.CloseConnection();
                return Grondstoffen;
            }

                }
    }
}
