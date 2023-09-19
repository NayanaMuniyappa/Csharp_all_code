using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study
{
    class Student
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
    class App:Info
    {
        public static void Main(string[] args)
        {
            //senario 1 with object;
            Student obj1 = new Student();
            obj1.s_Name = "Nayana";
            obj1.ID = 109;
            obj1.Date = Convert.ToDateTime("03/06/2001");
            Student obj2 = new Student();
            obj2.s_Name = "Veena";
            obj2.ID = 189;
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
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Enter {i} student Name.....");
                array[i] = new Student();
                array[i].s_Name = ReadLine();
                Console.WriteLine($"enter the ID {i} student....");
                array[i].ID = int.Parse(ReadLine());
                Console.WriteLine("Enter the {i} student Date of birth in the format of year,month,day...");
                int year = int.Parse(ReadLine());
                int month = int.Parse(ReadLine());
                int day = int.Parse(ReadLine());
                array[i].Date = new DateTime(year, month, day);
            }
            Console.WriteLine("display through arraylist"); 
            Console.WriteLine("STUDENT_ID\t\t\tNAME\t\t\tDATEOFBIRTH");
            WriteLine(".......................................................................");
            for (int j=0;j<n;j++)
            {
                Console.WriteLine(array[j].ID+"\t\t\t\t"+array[j].s_Name+"\t\t\t"+array[j].Date.ToShortDateString());
            }
            Read();



        }
    }
}
