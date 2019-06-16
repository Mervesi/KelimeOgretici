using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class UserDataAccess
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public bool IsUserRegister(User user)
        {
            string connectionString = @"Data Source=MERVE-PC\MERVE; Initial Catalog=KelimeOgretici;Integrated Security=True;MultipleActiveResultSets=True";
            using (con = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand();
                cmd.CommandText = "select * from [KelimeOgretici].[dbo].[User] where [Name]='"+user.Name+"' And [Password]='"+user.Password+"'";
                cmd.Connection = con;
                con.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                    return true;
                else
                    return false;

            }
        }
    }
}
