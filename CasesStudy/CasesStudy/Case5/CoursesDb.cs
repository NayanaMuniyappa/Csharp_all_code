using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CasesStudy.Case5
{
    class CoursesDb
    {
      
            public SqlConnection con = null;
            public SqlCommand cmd = null;
            public SqlDataReader dr;


            public void Addcource(Cource cource)
            {
                Console.WriteLine("Enter Cource Name");
                cource.cource_name = Console.ReadLine();

                INSERT(cource.cource_name);
            }
            public void INSERT(string Course_Name)
            {

                try
                {
                    con = GetConnection();
                    cmd = new SqlCommand("Addcourse @Course_Name");
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Course_Name", Course_Name);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Course added successfully");

                    }
                    else
                        Console.WriteLine("Data not inserted");
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }

            }
            public void Display()
            {
                con = GetConnection();
                cmd = new SqlCommand("Select * from TblCources", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("ID=" + dr["Course_ID"]);
                    Console.WriteLine("Courses=" + dr["Cource_Name"]);

                    Console.WriteLine();
                }


            }
            public SqlConnection GetConnection()
            {
                con = new SqlConnection("Data Source=ICS-LT-HPNK9K3;Initial catalog=Casestudy;Integrated Security=True");
                con.Open();
                return con;
            }
            //public static void Main(String[] args)
            //{
            //    Cource cource = new Cource();
            //    CoursesDb CDB = new CoursesDb();
            //    CDB.Addcource(cource);
            //    CDB.Display();
            //    Console.Read();

            //}

    }
 }
