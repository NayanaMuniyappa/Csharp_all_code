using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study
{
   public  class Student
    {
        public string s_Name { get; set; }
        public int ID { get; set; }
        public DateTime Date { get; set; }
         

       
    }
    class Info
    {

        public void Display(Student obj)
        {
           
            WriteLine(obj.s_Name + "\t\t\t" + obj.ID + "\t\t\t" + obj.Date.ToShortDateString());

         }

    }
    class App
    {
        public static void Main(string[] args)
        {
            //senario 1 with object;
            Student obj1 = new Student();
            obj1.s_Name = "Nayana";
            obj1.ID = 1;
            obj1.Date = Convert.ToDateTime("03/06/2001");
            Student obj2 = new Student();
            obj2.s_Name = "Veena";
            obj2.ID = 2;
            obj2.Date = new DateTime(2000,2,2);
            Console.WriteLine("Display through objects manual implementation");
            WriteLine("NAME\t\t\tID\t\t\tDATEOFBIRTH");
            WriteLine(".......................................................................");
            Info INFO= new Info();
            INFO.Display(obj2);
            INFO.Display(obj1);



            //senario 2 iterating through array
            Student[] array = new Student[20];
            Console.WriteLine("enter the no of student");
            int n = int.Parse(ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i+1} student Name.....");
                array[i] = new Student();
                array[i].s_Name = ReadLine();
                Console.WriteLine($"enter the ID {i+1} student....");
                array[i].ID = int.Parse(ReadLine());
                Console.WriteLine($"Enter the {i+1} student Date of birth in the format of year,month,day...");
                int year = int.Parse(ReadLine());
                int month = int.Parse(ReadLine());
                int day = int.Parse(ReadLine());
                array[i].Date = new DateTime(year, month, day);
            }

            Console.WriteLine("display through arraylist");
            Console.WriteLine("STUDENT_ID\t\t\tNAME\t\t\tDATEOFBIRTH");
            WriteLine(".......................................................................");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(array[j].ID + "\t\t\t\t" + array[j].s_Name + "\t\t\t" + array[j].Date.ToShortDateString());
            }
            //Console.WriteLine("Student Registration\n..............................");
            //AppEngine registration = new AppEngine();

            //registration.register(obj1);
            //registration.register(obj2);

            //Console.WriteLine("List of student Registered\n.................");
            //Student[] student_rigestered_list = new Student[30];
            //student_rigestered_list = registration.listOfStudents();
            //foreach (var v in student_rigestered_list)
            //{
            //    Console.WriteLine(v.s_Name);
            //}

            //int? loop = 0;
            //while (loop !=null)
            //{
            //    Console.WriteLine("1.Introduce cource 2.list of cource 3.student_Enrollement 4. list of enrolments Type '5' to terminate");
            //    char  c = char.Parse(Console.ReadLine());

            //    switch (c)
            //    {
            //        case '1':
            //            registration.introduce();
            //            break;
            //        case '2':
            //            {
            //                Cource[]cource_list = new Cource[20];
            //                cource_list = registration.listOfCourses();
            //                foreach (var v in cource_list)
            //                {
            //                    Console.WriteLine(v.cource);
            //                }
            //            }
            //            break;
            //        case '3':
            //            {

            //                Console.WriteLine("enter the cource");
            //                Cource cc = new Cource(ReadLine());
            //                registration.Enroll(obj2, cc);
            //            }
            //            break;
            //        case '4':
            //            {
            //               // ENROLLMENT[] list_of_enrolled = new ENROLLMENT[20];
            //                var  list_of_enrolled = registration.listOfEnrollments();
            //                Console.WriteLine("Student_ID\t\tSTUDENT\t\tDATE\t\t course\n...........................................................................");
            //                foreach (var v in list_of_enrolled)
            //                {
            //                    Console.WriteLine($"{v.student.ID}\t\t\t{v.student.s_Name}\t\t{v.student.Date.ToShortDateString()}\t\t{ v.course.cource}");
            //                    Console.ReadLine();
            //                }

            //            }
            //            break;
            //        case '5':loop = null;
            //            break;
            //        default:
            //            {
            //                Console.WriteLine("choose correct option");

            //            }
            //            break;

            //    }
            //}
            Read();



        }
    }
}
