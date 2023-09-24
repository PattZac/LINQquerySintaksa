using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;

public class Program
{
    public static void Main()
    {
        // Student collection
        List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John" } ,
                new Student() { StudentID = 2, StudentName = "Moin" } ,
                new Student() { StudentID = 3, StudentName = "Bill" } ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

        // upit i izvršavanje upita

        var query = from s in studentList
                    where s.StudentName.Contains('o')
                    select s;

        foreach( var s in query )
        {
            Console.WriteLine( s.StudentName );
        }

        Console.ReadLine();

    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
}