using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace employee
{
    class Emp
    {
        public int Empid;
        public string FName;
        public string LName;
        public string Title;
        public string DOB;
        public string DOJ;
        public string City;



    }
    class program
    {
        static void Main()
        {
            List<Emp> EmpList = new List<Emp>
            {
           new Emp{ Empid = 1001,   FName = "Malcolm", LName= "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai" },
           new Emp { Empid = 1002,  FName = "Asdin", LName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },
           new Emp{ Empid = 1003, FName = "Madhavi", LName = "Oza", Title = "Consultant", DOB = "14/11/1987", DOJ = "12/4/2015", City = "Pune" },
           new Emp{ Empid = 1004, FName = "Saba", LName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016", City = "Pune" },
           new Emp{ Empid = 1005,   FName = "Nazia", LName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016", City = "Mumbai" },
           new Emp{ Empid = 1006, FName = "Amit", LName = "Pathak", Title = "Consultant", DOB = "7/11/1989", DOJ = "8/8/2014", City = "Chennai" },
           new Emp{ Empid = 1007, FName = "Vijay", LName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015", City = "Mumbai" },
           new Emp{ Empid = 1008, FName = "Rahul", LName = "Dubey", Title = "Associate", DOB = "11/11/1993", DOJ = "6/11/2014", City = "Chennai" },
           new Emp { Empid = 1009, FName = "Suresh", LName = "Mistry", Title = "Associate", DOB = "12/8/1992", DOJ = "3/12/2014", City = "Chennai" },
           new Emp{ Empid = 1010, FName = "Sumit", LName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ ="2/1/2016", City = "Pune" }
           };



            Console.WriteLine("Details of employee");
            foreach (var empdetails in EmpList)
            {
                Console.WriteLine($"EmployeeID: {empdetails.Empid}, Name: {empdetails.FName} {empdetails.LName}, Title: {empdetails.Title}, DOB: {empdetails.DOB}, DOJ: {empdetails.DOJ}, City: {empdetails.City}");
            }



            var notMumbaiEmployee = EmpList.Where(emp => emp.City != "Mumbai").ToList();
            Console.WriteLine("\nDetails of employees who are not in mumbai");
            foreach (var emp in notMumbaiEmployee)
            {
                Console.WriteLine($"EmployeeID: {emp.Empid}, Name: {emp.FName} {emp.LName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }



            var astManagers = EmpList.Where(emp => emp.Title == "AsstManager").ToList();
            Console.WriteLine("\nASSISSTANT MANAGER");
            foreach (var emp in astManagers)
            {
                Console.WriteLine($"EmployeeID: {emp.Empid}, Name: {emp.FName} {emp.LName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }



            var S = EmpList.Where(emp => emp.LName.StartsWith("S")).ToList();
            Console.WriteLine("\nDetails of employees whose Last Name starts with 'S':");
            foreach (var emp in S)
            {
                Console.WriteLine($"EmployeeID: {emp.Empid}, Name: {emp.FName} {emp.LName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }
            Console.ReadLine();
        }



    }



}