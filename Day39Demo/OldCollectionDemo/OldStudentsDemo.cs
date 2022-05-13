using Day39Demo.Models;
using System.Collections;

namespace Day39Demo.OldCollectionDemo;

public class OldStudentsDemo
{
    public void Test()
    {
        //var s1 = new Student { Id = 100, Name = "Vidya", Age = 37 };
        //int i = 10;
        //Console.WriteLine(i);
        //Console.WriteLine(s1);        


        var studentsArray = new Student[10];
        var students = new ArrayList();

        students.Add(new Student { Id = 1, Name = "Akshay", Age = 45 });
        students.Add(new Student { Id = 2, Name = "Salman", Age = 47 });

        students.Add(10);
        students.Add("Who is this?");

        foreach (var item in students)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("*****************");
        foreach (var s in students)
        {
            var temps = (Student)s;

            Console.WriteLine(temps.Age);
        }
    }
}
