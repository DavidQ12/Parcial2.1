using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Joyeria_Parcial.Properties;





namespace Joyeria_Parcial.DAL
{
    public class DATABASE
    { public static string GetSttrConnection();
      return Settings.Default.Joyeria_ParcialConnectionString




    public SqlConnection getConnection()
        {
            {
                SqlConnection Con = new SqlConnection(getStrConnection());
                return Con;

            }

}

        public bool testConection()
        {
            SqlConnection Con = this.getConnection();
            Con.Open();
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }



        
}
