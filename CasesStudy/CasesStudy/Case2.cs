using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasesStudy
{
    public class Cource
    {
        public string cource_name { get; set; }
        public int course_id { get; set; }


    }
    public class ENROLLMENT
    {

        public Student student { get; set; }
        public Cource course { get; set; }
        public DateTime EnrollmentDate { get; set; }



    }
    //    public class AppEngine
    //    {

    //        List<Student> Register_students = new List<Student>();
    //        List<ENROLLMENT> ENROLLS = new List<ENROLLMENT>();
    //        List<Cource> cources = new List<Cource>();
    //        public void introduce(string c_name, int c_id)
    //        {

    //            Cource cc = new Cource(c_name, c_id);
    //            cources.Add(cc);

    //        }
    //        public void register(Student student)
    //        {

    //            Register_students.Add(student);

    //        }

    //        public Student[] listOfStudents()
    //        {

    //            List<Student> STUDENT = new List<Student>();
    //            STUDENT = Register_students;
    //            return STUDENT.ToArray();

    //        }

    //        public Cource[] listOfCourses()
    //        {
    //            return cources.ToArray();


    //        }
    //        public void Enroll(Student student, Cource course)
    //        {

    //            ENROLLS.Add(new ENROLLMENT(student, course, DateTime.Now));
    //        }
    //        public ENROLLMENT[] listOfEnrollments()
    //        {
    //            return ENROLLS.ToArray();

    //        }
    //    }
}
