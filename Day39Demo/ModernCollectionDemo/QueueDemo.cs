using Day39Demo.Models;

namespace Day39Demo.ModernCollectionDemo;

public class QueueDemo
{
    public static void Test()
    {
        var q = new Queue<Student>();   // FIFO

        q.Enqueue(new Student { Id = 1, RollNumber = 59, Name = "Kapil Sharma", Age = 38, Telephone = "1000000", Email = "aa@aa.com"});
        q.Enqueue(new Student { Id = 2, RollNumber = 25, Name = "Komal Sharma", Age = 38, Telephone = "1000000", Email = "aa@aa.com" });
        q.Enqueue(new Student { Id = 3, RollNumber = 33, Name = "Raman Gujral", Age = 38, Telephone = "1000000", Email = "aa@aa.com" });

        Student s = q.Dequeue();

        Console.Write("**QueueDemo**");
        Console.WriteLine(s);
    }
}
