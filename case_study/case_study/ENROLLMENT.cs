using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study
{
    public class Cource
    {
        public string cource { get; set; }

        public Cource(string cource)
        {
            this.cource = cource;

        }
    }
   public class ENROLLMENT
    {

        public Student student { get; set; }
        public Cource course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
            public ENROLLMENT(Student SS, Cource CC, DateTime DD)
            {
                student = SS;
                course = CC;
                EnrollmentDate = DD;
            }

    }
      public  class AppEngine
      {

        List<Student> Register_students = new List<Student>();
        List<ENROLLMENT> ENROLLS = new List<ENROLLMENT>();
        List<Cource> cources = new List<Cource>();
        public void introduce()
        {
            Console.WriteLine("ENTER THE NEW COURSE NAME\n..............................");
            Console.Write("COURSE_NAME=");
            Cource cc = new Cource(Console.ReadLine());
                cources.Add(cc);

        }
        public void register(Student student)
        {

            Register_students.Add(student);
          
        }
        public Student[] listOfStudents()
        { 
       
            List<Student> STUDENT = new List<Student>();
            STUDENT = Register_students;
            return STUDENT.ToArray();
          
        }
      
        public Cource[] listOfCourses()
        {
            return cources.ToArray();
            

        }
        public void Enroll(Student student, Cource course)
        {
            
            ENROLLS.Add(new ENROLLMENT(student, course, DateTime.Now));
        }
        public ENROLLMENT[] listOfEnrollments()
        {
            return ENROLLS.ToArray();

        }
      }

}


