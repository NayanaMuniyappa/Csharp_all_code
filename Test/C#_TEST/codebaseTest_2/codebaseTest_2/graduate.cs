//<symmary>


using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }
    public double Grade { get; set; }

    public abstract bool IsPassed(double grade);
}

public class Undergraduate : Student
{
    public override bool IsPassed(double grade)
    {
        if (grade > 70.0)
            return true;
        else
            return false;
       
    }
}

public class Graduate : Student
{
    public override bool IsPassed(double grade)
    {
        if (grade > 80.0)
            return true;
        else
            return false;
    }

    public static void Main(string[] args)
    {
        Undergraduate ud = new Undergraduate();
        ud.Name = "Nayana";
        ud.StudentId = 109;
        ud.Grade = 70;

        Graduate gd = new Graduate();
        gd.Name = "veena";
        gd.StudentId = 189;
        gd.Grade = 85.0;

        WriteLine($"{ud.Name} passed: {ud.IsPassed(ud.Grade)}");
        WriteLine($"{gd.Name} passed: {gd.IsPassed(gd.Grade)}");
        ReadLine();
    }

}