using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebasetest_3
{
    class cricket
    {
        static void Main(string[] args)
        {
            Tuple<int,double> tt= Sum_average();
            Console.WriteLine(  $"The total points scored {tt.Item1} the average points {tt.Item2}");
            Console.Read();
        }
        static Tuple<int, double> Sum_average()
        {
            int number_of_matches = 0,total_score=0;
            double avg;
            int[] points = new int[20];
            Console.WriteLine("ENTER THE NO OF MATHCHES PLAYED");
            number_of_matches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE TOTAL SCORE IN EACH MATCH");
            for (int j = 0; j < number_of_matches; j++)
            {
                points[j] = Convert.ToInt32(Console.ReadLine());


                total_score = total_score + points[j];
            }

            
            avg = (total_score / number_of_matches);
            Tuple<int, double> tp = Tuple.Create(total_score, avg);
            return tp;
        }
    }
}
