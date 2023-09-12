using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Student
{
    private string rollNo;
    private string name;
    private string studentClass;
    private string semester;
    private string branch;
    private int[] marks = new int[5];

    public Student(string rollNo, string name, string studentClass, string semester, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.studentClass = studentClass;
        this.semester = semester;
        this.branch = branch;
    }

    public void GetMarks()
    {
        WriteLine($"Enter marks for {name}:");
        for (int i = 0; i < 5; i++)
        {
            Write($"Enter marks for Subject {i + 1}: ");
            marks[i] = Convert.ToInt32(ReadLine());
        }
    }

    public double CalculateAverage()
    {
        double totalMarks = 0;
        foreach (int mark in marks)
        {
            totalMarks += mark;
        }

        return totalMarks / marks.Length;
    }

    public void DisplayResult()
    {
        double average = CalculateAverage();
        bool passed = true;

        foreach (int mark in marks)
        {
            if (mark < 35)
            {
                passed = false;
                break;
            }
        }

        if (passed && average >= 50)
        {
            WriteLine($"Result for {name}: Passed");
        }
        else
        {
            WriteLine($"Result for {name}: Failed");
        }
    }

    public void DisplayData()
    {
        WriteLine($"Roll Number: {rollNo}");
        WriteLine($"Name: {name}");
        WriteLine($"Class: {studentClass}");
        WriteLine($"Semester: {semester}");
        WriteLine($"Branch: {branch}");
        WriteLine($"Marks: [{string.Join(", ", marks)}]");
    }

    public static void Main(string[] args)
    {
        Student student = new Student("109", "Nayana", "4", "3rd", "cse");
        student.GetMarks();
        student.DisplayData();
        student.DisplayResult();
        Read();
        
    }
}
