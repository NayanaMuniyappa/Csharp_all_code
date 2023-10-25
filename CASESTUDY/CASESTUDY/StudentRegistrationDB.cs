using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CASESTUDY;

namespace CASESTUDY
{
    class StudentRegistrationDB
    {

        public  SqlConnection con = null;
        public SqlCommand cmd = null;
        public SqlDataReader dr;


        public void Register(Student student)
        {
            Console.WriteLine("Enter the student Name:");
            student.s_Name = Console.ReadLine();

            Console.WriteLine("Enter Student ID");
            student.ID = Convert.ToInt32(Console.ReadLine());

            INSERT(student.s_Name, student.ID, DateTime.Now);
        }
        public void INSERT(string Name,int ID,DateTime DOR)
        { 
           
            try
            {
                con = GetConnection();
            
                cmd = new SqlCommand("insert into Student_Registration(ID,Name,DOR)values(@ID,@Name,@DOR)");
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@ID",ID);
                cmd.Parameters.AddWithValue("@Name",Name);
                cmd.Parameters.AddWithValue("@DOR",DOR);

                int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine("Values Inserted successfully");

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
            cmd = new SqlCommand("Select * from Student_Registration", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ID="+dr["ID"]);
                Console.WriteLine("NAME="+dr["Name"]);
                Console.WriteLine("REGISTERED DATE="+dr["DOR"]);
                Console.WriteLine();
            }


        }
        public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-HPNK9K3;Initial catalog=Casestudy;Integrated Security=True");
            con.Open();
            return con;
        }
        public static void Main(String[] args)
        {
            Student student = new Student();
            StudentRegistrationDB REG = new StudentRegistrationDB();
            REG.Register(student);
            REG.Display();
            Console.Read();

        }

    }
}
