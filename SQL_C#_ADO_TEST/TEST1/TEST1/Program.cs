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
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
       
        public static SqlConnection getconnection()
        {
            conn = new SqlConnection("Data Source=ICS-LT-HPNK9K3;Initial catalog=SQL_ADO_TEST;Integrated Security=True");
          
            conn.Open();
            return conn;

        }
        public static void display()
        {
            conn = getconnection();
            cmd = new SqlCommand("SELECT * FROM Code_Employee", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("Employee Records:");
            while (dr.Read())
            {

                Console.WriteLine($"Employee ID: {dr["empno"]}, Name: {dr["empname"]}, Salary: {dr["empsal"]}, Type: {dr["emptype"]}");

            }
            conn.Close();

        }
        public static void Main()
        {
            try
            {

                conn = getconnection();

                cmd = new SqlCommand(" Addemplyoee", conn);
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
            display();

            Console.Read();
        }

    }

}


