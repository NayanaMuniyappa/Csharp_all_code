using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CasesStudy;

namespace CasesStudy
{
    class case3and4
    {
        public interface IUserInterface
        {
            void ShowFirstScreen();
            void ShowStudentScreen();
            void ShowAdminScreen();
            void ShowAllStudentsScreen();
            void ShowStudentRegistrationScreen();
            void IntroduceNewCourseScreen();
            void ShowAllCoursesScreen();

            void Enrollment();
        }

        public class UserInterface : IUserInterface
        {
            // public CasesStudy.AppEngine appEngine = new CasesStudy.AppEngine();

            public void ShowFirstScreen()
            {
                Console.WriteLine("\t\tSTUDENT MANAGEMENT SYSTEM\n.........................................................");
                Console.WriteLine("\t\t\tDASHBOARD\n..........................................................");
                Console.WriteLine("HOME MENU: \n1.STUDENT\n2.ADMIN\n3.EXIT");
                Console.Write("ENTER YOUR CHOICE : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ShowStudentScreen();
                        break;
                    case 2:
                        ShowAdminScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        ShowFirstScreen();
                        break;
                }
            }

            public void ShowStudentScreen()
            {
                Console.WriteLine("..................................STUDENT SCREEN...................................");
                Console.WriteLine("1.COURSE LIST");
                Console.WriteLine("2.Registration");
                Console.WriteLine("3.EXIT");
                Console.Write("ENTER YOUR CHOICE: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowAllCoursesScreen();
                        break;
                    case 2:
                        ShowStudentRegistrationScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exiting................");
                        ShowFirstScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                        ShowStudentScreen();
                        break;
                }
            }

            public void ShowAdminScreen()
            {
                Console.WriteLine("...........................ADMIN SCREEN.............................................");
                Console.WriteLine("1.COURSE INTRODUCE");

                Console.WriteLine("2.COURSE LIST");

                Console.WriteLine("3.STUDENT REGISTRATION");

                Console.WriteLine("4.STUDENT LIST");

                Console.WriteLine("5.STUDENT ENROLLMENT");

                Console.WriteLine("6.ENROLLMENT LIST");

                Console.WriteLine("7.DASHBOARD");

                Console.WriteLine("8.EXIT");

                Console.Write("ENTER YOUR CHOICE:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        IntroduceNewCourseScreen();
                        break;
                    case 3:
                        ShowStudentRegistrationScreen();
                        break;
                    case 4:
                        ShowAllStudentsScreen();
                        break;
                    case 2:
                        ShowAllCoursesScreen();
                        break;
                    case 5:
                        Enrollment();
                        break;
                    case 6:
                        EnrollmentList();
                        break;
                    case 7:
                        ShowFirstScreen();
                        break;
                    case 8:
                        Console.WriteLine("Exiting Admin Menu. Thank you");
                        ShowFirstScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                        ShowAdminScreen();
                        break;
                }
            }

            public void ShowAllStudentsScreen()
            {
                //Console.WriteLine("List of Students:");
                //Console.WriteLine("STUDENT_ID\t\t\tNAME\t\t\tDATEOFBIRTH");
                //WriteLine(".......................................................................");
                //foreach (Student student in appEngine.listOfStudents())
                //{
                //    Console.WriteLine($"{student.ID}\t\t\t\t{student.s_Name}\t\t\t\t{student.Date.ToShortDateString()}");
                //}
                Student student = new Student();
                Case5.StudentRegistrationDb REG = new Case5.StudentRegistrationDb();
                REG.Display();
                Console.WriteLine("...............................................................................");

                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowAdminScreen();
            }

            public void ShowStudentRegistrationScreen()
            {
                //Student student = new Student();
                //Console.WriteLine("ENTER THE STUDENT NAME");
                //student.s_Name = Console.ReadLine();
                //Console.WriteLine("ENTER ID");
                //student.ID = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("ENTER THE DATE OF BIRTH OF STUDENT IN 'YYYY MM DD' FORMAT");
                //int YEAR = Convert.ToInt32(Console.ReadLine());
                //int MONTH = Convert.ToInt32(Console.ReadLine());
                //int DATE = Convert.ToInt32(Console.ReadLine());
                //student.Date = new DateTime(YEAR, MONTH, DATE);

                //// Register the student
                //appEngine.register(student);



                Student student = new Student();
                Case5.StudentRegistrationDb REG = new Case5.StudentRegistrationDb();
                REG.Register(student);

                Console.WriteLine("Student registered successfully...........................");
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowStudentScreen();
            }

            public void IntroduceNewCourseScreen()
            {
                //Console.Write("Enter Course ID: ");
                //int courseId = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Enter Course Name: ");
                //string courseName = Console.ReadLine();

                // Introduce a new course
                //appEngine.introduce(courseName, courseId);
                //Console.WriteLine("Course introduced successfully.");
                //Console.WriteLine("Press Enter to return to the previous menu...");
                //Console.ReadLine();
                Case5.CoursesDb cource = new Case5.CoursesDb();
                Cource cc = new Cource();
                cource.Addcource(cc);
                ShowAdminScreen();
            }

            public void ShowAllCoursesScreen()
            {
                Console.WriteLine("List of Courses:");
                // Console.WriteLine("COURSE_ID\t\tCOURSE_NAME\n.......................................................");
                //foreach (Cource course in appEngine.listOfCourses())
                //{
                //    Console.WriteLine($"{course.course_id}\t\t\t\t{course.cource_name}");
                //}

                Case5.CoursesDb cource = new Case5.CoursesDb();
                cource.Display();
                ShowFirstScreen();

            }
            public void Enrollment()
            {

                //Student student = new Student();
                //Console.WriteLine("ENTER STUDENT ID");
                //student.ID = Convert.ToInt32(ReadLine());
                //Console.WriteLine("ENTER THE STUDENT NAME:");
                //student.s_Name = ReadLine();
                //Console.WriteLine("CHOICE THE COURSE ACCORDING  TO  BELOW LIST");
                //Console.WriteLine("COURSE_ID\t\tCOURSE_NAME\n.......................................................");
                //foreach (Cource course in appEngine.listOfCourses())
                //{
                //    Console.WriteLine($"{course.course_id}\t\t\t\t{course.cource_name}");
                //}
                //Console.WriteLine("ENTER COURSE ID\n");
                //int ID = Convert.ToInt32(ReadLine());
                //Console.WriteLine("ENTER COURSE NAME\n");
                //string C_NAME = ReadLine();
                //Cource CC = new Cource(C_NAME, ID);
                //appEngine.Enroll(student, CC);

                Student student = new Student();
                Cource cource = new Cource();

                ENROLLMENT enroll = new ENROLLMENT();
                Case5.Enrollmentdb ENDB = new Case5.Enrollmentdb();

                ENDB.Enroll(student, cource, enroll);

                Console.WriteLine("ENROLLED SUCCESSFULLY\n");
                Console.WriteLine("ENTER TO GO PREVIOUS MENU\n");
                ReadLine();
                ShowAdminScreen();

            }
            public void EnrollmentList()
            {
                //Console.WriteLine("ENROLLMENT LIST");
                //var list_of_enrolled = appEngine.listOfEnrollments();
                //Console.WriteLine("STUDENT_ID\t\tSTUDENT\t\tDATE\t\tCOURSE_ID\t\tCOURSE\n...........................................................................................");
                //foreach (var v in list_of_enrolled)
                //{
                //    Console.WriteLine($"{v.student.ID}\t\t\t{v.student.s_Name}\t\t{v.student.Date.ToShortDateString()}\t\t{ v.course.course_id}\t\t{v.course.cource_name} ");
                //    Console.ReadLine();
                //}

                Case5.Enrollmentdb ENDB = new Case5.Enrollmentdb();
                ENDB.Display();
                Console.WriteLine("ENTER TO GO FOR DASHBOARD");
                ReadLine();
                ShowFirstScreen();
            }


            public static void Main(string[] args)
            {
                UserInterface User = new UserInterface();
                User.ShowFirstScreen();
                Read();

            }


        }
    }
}
