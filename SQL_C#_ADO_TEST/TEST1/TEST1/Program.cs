using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TEST1
{
    class Program
    {
        public static SqlConnection conn = null;
        public  static SqlCommand cmd = null;
        public static void Main()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=ICS-LT-HPNK9K3;Initial catalog=SQL_ADO_TEST"
                        + "Integrated Security=True");
                conn.Open();
               
                cmd = new SqlCommand("AddEmployee @empname,@empsal,@emptype", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empname", "veena");
                cmd.Parameters.AddWithValue("@empsal", 30000.00);
                cmd.Parameters.AddWithValue("@emptype", "F");
                    cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.Read();
        }

     }

}


