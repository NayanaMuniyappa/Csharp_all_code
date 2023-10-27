using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CasesStudy.Case5
{
    class Enrollmentdb
    {
       
            public SqlConnection con = null;
            public SqlCommand cmd = null;
            public SqlDataReader dr;

            public void Enroll(Student student,Cource cource,ENROLLMENT enroll)
            {
                Console.WriteLine("Enter the Student_id");
                student.ID = Convert.ToInt32(Console.ReadLine());
           
                Console.WriteLine("Enter Cource id");
                cource.course_id = Convert.ToInt32(Console.ReadLine());

                enroll.EnrollmentDate = DateTime.Now;
                
               INSERT(student.ID,cource.course_id,enroll.EnrollmentDate);
            }
            public void INSERT(int Student_ID, int Course_ID,DateTime Date_enrollment)
            {

                try
                {
                    con = GetConnection();
                    cmd = new SqlCommand("procedure_enroll @Student_ID,@Course_ID,@Date_enrollment");
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Student_ID", Student_ID);
                    cmd.Parameters.AddWithValue("@Course_ID", Course_ID);
                    cmd.Parameters.AddWithValue("@Date_enrollment", Date_enrollment);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Enrolled successfully");

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
                cmd = new SqlCommand("Select * from TblEnrollment", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student_ID=" + dr["Student_ID"]);
                    Console.WriteLine("Student_name=" + dr["Student_Name"]);
                    Console.WriteLine("Course_ID=" + dr["Course_ID"]);
                    Console.WriteLine("Enrollment_date=" + dr["Date_enrollment"]);
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
            //    Student student = new Student();
            //    Cource cource = new Cource();
               
            //    ENROLLMENT enroll = new ENROLLMENT();
            //    Enrollmentdb ENDB = new Enrollmentdb();
                
            //    ENDB.Enroll(student,cource,enroll);
            //    ENDB.Display();


            //    Console.Read();



            //}

        }
    }
