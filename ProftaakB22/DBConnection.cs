using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace ProftaakB22
{
    class DBConnection
    {
        private SqlConnection connection;
        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-K7MLI2P\SQLEXPRESS;Initial Catalog=ProftaakB22;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //       SqlConnection con = new SqlConnection("Server=DESKTOP-K7MLI2P\\SQLEXPRESS;AttachDbFilename=C:\\Program Files(x86)\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\DATA\\ProftaakB22.mdf;Database=ProftaakB22;Trusted_Connection = Yes;");

            connection = con;
         
        }
        public SqlConnection Connection
        {
            get { return this.connection; }
        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("open");
                return true;

            }
            catch 
            {
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
