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

        public void Display(Student[] objects)
        {
             foreach(var obj in objects)
            { 
                Console.WriteLine(obj.ID + "\t\t\t" + obj.s_Name + "\t\t\t" + obj.Date.ToShortDateString());
         
            }
        }

    }
    class App
    {
        public static void Main(string[] args)
        {
            ////senario 1 with object;
            //Student obj1 = new Student();
            //obj1.s_Name = "Nayana";
            //obj1.ID = 1;
            //obj1.Date = Convert.ToDateTime("03/06/2001");
            //Student obj2 = new Student();
            //obj2.s_Name = "Veena";
            //obj2.ID = 2;
            //obj2.Date = new DateTime(2000,2,2);
            //Console.WriteLine("Display through objects manual implementation");
            //WriteLine("NAME\t\t\tID\t\t\tDATEOFBIRTH");
            //WriteLine(".......................................................................");
            //Info INFO= new Info();
            //INFO.Display(obj2);
            //INFO.Display(obj1);



            //senario 2 iterating through array
            //Student[] array = new Student[20];
            //Console.WriteLine("enter the no of student");
            //int n = int.Parse(ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter {i+1} student Name.....");
            //    array[i] = new Student();
            //    array[i].s_Name = ReadLine();
            //    Console.WriteLine($"enter the ID {i+1} student....");
            //    array[i].ID = int.Parse(ReadLine());
            //    Console.WriteLine($"Enter the {i+1} student Date of birth in the format of year,month,day...");
            //    int year = int.Parse(ReadLine());
            //    int month = int.Parse(ReadLine());
            //    int day = int.Parse(ReadLine());
            //    array[i].Date = new DateTime(year, month, day);
            //}
            /// Console.WriteLine("STUDENT_ID\t\t\tNAME\t\t\tDATEOFBIRTH");
            ////WriteLine(".......................................................................");
            ////for (int j = 0; j < n; j++)
            ////{
            ////    Console.WriteLine(array[j].ID + "\t\t\t\t" + array[j].s_Name + "\t\t\t" + array[j].Date.ToShortDateString());
            ////}


            //Console.WriteLine("Student Registration\n..............................");
            //

           

            //Console.WriteLine("List of student Registered\n.................");
            //Student[] student_rigestered_list = new Student[30];
            //student_rigestered_list = Appengine.listOfStudents();
            //foreach (var v in student_rigestered_list)
            //{
            //    Console.WriteLine(v.s_Name);
            //}

            //int? loop = 0;
            //while (loop != null)
            //{
            //    Console.WriteLine("1.REGESTRATION\n2.REGISTRATION LIST\n3.INTRODUCE COURSE\n4.COURSE LIST\n5.ENROLLMENT\n6.ENROLLMET LIST\n7.EXIT");
            //    char c = char.Parse(Console.ReadLine());
            //    Student student = new Student();
            //    AppEngine Appengine = new AppEngine();
            //    Info Display = new Info();

            //    switch (c)
            //    {
            //        case '1':Appengine.register(student);
            //            break;
            //        case '2':
            //            {
            //                Student[] STUDENT_REGISTERED = new Student[100];
            //                STUDENT_REGISTERED = Appengine.listOfStudents();
            //                Console.WriteLine("STUDENT_ID\t\t\tNAME\t\t\tDATEOFBIRTH");
            //                WriteLine(".......................................................................");
            //                Display.Display(STUDENT_REGISTERED);
            //            }
            //        break;
            //        case '3':Appengine.introduce();
            //            break;
                    
            //        case '4':
            //            {
            //                Cource[] cource_list = new Cource[20];
            //                cource_list = Appengine.listOfCourses();
            //                foreach (var v in cource_list)
            //                {
            //                    Console.WriteLine(v.cource);
            //                }
            //            }
            //            break;
            //        case '5':
            //            {

            //                Console.WriteLine("enter the cource");
            //                Cource cc = new Cource(ReadLine());
            //                Appengine.Enroll(student, cc);
            //            }
            //            break;
            //        case '6':
            //            {
            //                // ENROLLMENT[] list_of_enrolled = new ENROLLMENT[20];
            //                var list_of_enrolled = Appengine.listOfEnrollments();
            //                Console.WriteLine("Student_ID\t\tSTUDENT\t\tDATE\t\t course\n...........................................................................");
            //                foreach (var v in list_of_enrolled)
            //                {
            //                    Console.WriteLine($"{v.student.ID}\t\t\t{v.student.s_Name}\t\t{v.student.Date.ToShortDateString()}\t\t{ v.course.cource}");
            //                    Console.ReadLine();
            //                }

            //            }
            //            break;
            //        case '7':
            //            loop = null;
            //            Console.WriteLine("THANK U");
            //            break;
            //        default:
            //            {
            //                Console.WriteLine("choose correct option");

            //            }
            //            break;

            //    }
            //}
            //Read();



        }
    }
}
