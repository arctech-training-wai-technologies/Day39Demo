using Day39Demo.Models;
using System.Diagnostics;

namespace Day39Demo.ModernCollectionDemo;

public class GenericDictionaryDemo
{
    const int TotalStudents = 50000;
    public static void Test()
    {
        TestList();
        TestDictionary();
    }

    public static void TestDictionary()
    {
        var classRoom = new Dictionary<int, Student>();

        for (int i = 1; i <= TotalStudents; i++)
        {
            var student = new Student();
            student.Id = i;
            student.RollNumber = 100 + i;
            student.Name = Faker.Name.FullName();
            student.Age = Faker.RandomNumber.Next(18, 55);
            student.Email = Faker.Internet.Email();
            student.Telephone = Faker.Phone.Number();

            classRoom.Add(student.RollNumber, student);
        }

        Stopwatch sw = new();
        sw.Start();
        var studentToFind = classRoom[45000];       // Very fast binary Search

        sw.Stop();

        Console.WriteLine($"Dictionary time taken to search: {sw.ElapsedMilliseconds}");

        if (studentToFind == null)
            Console.WriteLine("No Student has this roll no!");
        else
            Console.WriteLine(studentToFind);
    }

    public static void TestList()
    {
        var classRoom = new List<Student>();

        for (int i = 1; i <= TotalStudents; i++)
        {
            var student = new Student();
            student.Id = i;
            student.RollNumber = 100 + i;
            student.Name = Faker.Name.FullName();
            student.Age = Faker.RandomNumber.Next(18, 55);
            student.Email = Faker.Internet.Email();
            student.Telephone = Faker.Phone.Number();

            classRoom.Add(student);
        }

        Stopwatch sw = new();
        sw.Start();
        var studentToFind = classRoom.FirstOrDefault(s => s.RollNumber == 45000); // very slow linear search
        sw.Stop();

        Console.WriteLine($"List Time taken to search: {sw.ElapsedMilliseconds}");

        if (studentToFind == null)
            Console.WriteLine("No Student has this roll no!");
        else
            Console.WriteLine(studentToFind);

        //classRoom.Add(101, new Student { Id = 1, Name = "Amrish Puri", Age = 55 });
        //classRoom.Add(102, new Student { Id = 2, Name = "Ranveer", Age = 32 });
        //classRoom.Add(101, new Student { Id = 3, Name = "Amrish Puri", Age = 55 });
        //classRoom.Add(102, new Student { Id = 4, Name = "Ranveer", Age = 32 });
        //classRoom.Add(101, new Student { Id = 5, Name = "Amrish Puri", Age = 55 });
        //classRoom.Add(102, new Student { Id = 6, Name = "Ranveer", Age = 32 });
        //classRoom.Add(101, new Student { Id = 7, Name = "Amrish Puri", Age = 55 });
        //classRoom.Add(102, new Student { Id = 8, Name = "Ranveer", Age = 32 });
        //classRoom.Add(101, new Student { Id = 9, Name = "Amrish Puri", Age = 55 });
        //classRoom.Add(102, new Student { Id = 10, Name = "Ranveer", Age = 32 });
    }
}
