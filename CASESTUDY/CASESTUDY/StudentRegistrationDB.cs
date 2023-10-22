using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CASESTUDY
{
    class StudentRegistrationDB
    {

       public void Register(Student student)
        {
             SqlConnection con = null;
             SqlCommand cmd = null;

            try
            {
                con = new SqlConnection("Data Source=ICS-LT-HPNK9K3;Initial catalog=Student_Registration" 
                    + "Integrated Security=True");
                con.Open();
                Console.WriteLine("Enter Student Name:");
                student.s_Name = Console.ReadLine();
                student.ID = Convert.ToInt32(Console.ReadLine());
                student.Date = DateTime.Now;
                cmd=new SqlCommand("insert into Student_Registration values(@student.s_name,@student.Id,@student.Date)");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Console.WriteLine( "Values Inserted successfully");

            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
          
        }
        public static void Main(String[] args)
        {
            Student student = new Student();
            StudentRegistrationDB REG = new StudentRegistrationDB();
            REG.Register(student);
            Console.Read();

        }
    }
}
