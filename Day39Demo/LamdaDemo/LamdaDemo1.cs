using Day39Demo.Models;

namespace Day39Demo.LamdaDemo;

public class LamdaDemo1
{
    public static void Test()
    {
        WithLamda();

        WithoutLamda();
    }

    private static void WithoutLamda()
    {
        int[] numbers = { 5, 10, 8, 3, 6, 12 };

        var output = new List<int>();

        foreach (var item in numbers)
        {
            if (item % 2 == 0)
                output.Add(item);
        }

        output.Sort();

        Console.WriteLine("**Without Lamda**");
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }

    private static void WithLamda()
    {
        int[] numbers = { 5, 10, 8, 3, 6, 12 };

        IEnumerable<int> numQuery2 = numbers
                                        .Where(num => num % 2 == 0)
                                        .OrderBy(num => num);

        Console.WriteLine("**With Lamda**");
        foreach (var item in numQuery2)
        {
            Console.WriteLine(item);
        }
    }

    private static void WithLamdaForStudent()
    {
        Student[] students = new Student[]
        {
            new Student { Id = 5, Name="AAA"   },
            new Student { Id = 10, Name="AAA"   },
            new Student { Id = 8, Name="AAA"   },
            new Student { Id = 3, Name="AAA"   },
            new Student { Id = 6, Name="AAA"   },
            new Student { Id = 12, Name="AAA"   }
        };

        IEnumerable<Student> studentQuery2 = students
                                        //.Where(s => s.Id % 2 == 0)
                                        .Where(s => s.Name.StartsWith("A"))
                                        .OrderBy(s => s.Id);

        Console.WriteLine("**With Lamda**");
        foreach (var item in studentQuery2)
        {
            Console.WriteLine(item);
        }        
    }
}
