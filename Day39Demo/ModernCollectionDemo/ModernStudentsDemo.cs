using Day39Demo.Models;

namespace Day39Demo.ModernCollectionDemo;

public class ModernStudentsDemo
{
    public static void Test()
    {
        var students = new List<Student>();

        students.Add(new Student { Id = 1, Name = "Akshay", Age = 45 });
        students.Add(new Student { Id = 2, Name = "Salman", Age = 47 });

        //students.Add(10);
        //students.Add("Who is this?");

        foreach (var item in students)
        {
            Console.WriteLine(item);
        }

        // students.ForEach(item => Console.WriteLine(item));
    }
}
