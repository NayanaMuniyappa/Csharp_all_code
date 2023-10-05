using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebasetest_4
{
    class File_test
    {
       public static void Main(string[] args)
       {
            writedata();
            readdata();
            Read();

       }
        public static void readdata()
        {
            FileStream fs = new FileStream(@"D:\CSharp_Training_all_day\Testdoc.txt ", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Current);
            string data = sr.ReadLine();
            while (data != null)
            {
                WriteLine(data);
                data = sr.ReadLine();

            }
            sr.Close();
            fs.Close();


        }


        public static void writedata()
            {
                FileStream fs = new FileStream(@"D:\CSharp_Training_all_day\Testdoc.txt", FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                WriteLine("enter the data to file");
                string data = ReadLine();
                sw.Write(data);
                Console.WriteLine("text added successfully");
                sw.Close();
                fs.Close();


            }
        }
    }
