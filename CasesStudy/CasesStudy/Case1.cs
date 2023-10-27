using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasesStudy
{
        public class Student
        {
            public string s_Name { get; set; }
            public int ID { get; set; }
            public DateTime Date { get; set; }

        }
        class Info
        {

            public void Display(Student[] objects)
            {
                foreach (var obj in objects)
                {
                    Console.WriteLine(obj.ID + "\t\t\t" + obj.s_Name + "\t\t\t" + obj.Date.ToShortDateString());

                }
            }
        }
}
