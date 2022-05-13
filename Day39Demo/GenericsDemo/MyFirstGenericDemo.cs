using Day39Demo.Models;

namespace Day39Demo.GenericsDemo;

public class MyFirstGenericDemo
{
    public static void TestClassLevel()
    {
        // No need to create separate classes if we use Generics
        /*
        var myDataStore = new MyDataStore();
        var myDataStoreT = new MyDataStoreForTeacher();
        */

        var myDataStore = new MyDataStore<Student>();

        myDataStore.Add(new Student { Id = 1, Name = "Sunil", Age = 55 });

        myDataStore.Remove(1);
        
        var myDataStoreT = new MyDataStore<Teacher>();
        myDataStoreT.Add(new Teacher { EmployeeId = 1, Name = "Sunil" });

        myDataStoreT.Remove(1);

        // Not allowed as class generic validation is specified as "class only", so int is not allowed
        //var intDataStore = new MyDataStore<int>();
    }

    public static void TestMethodLevel()
    {
        Console.WriteLine(Join(10, 20));
        Console.WriteLine(Join(1000, 2000));
        Console.WriteLine(Join(0.567, 1.555));
        Console.WriteLine(Join("Kareena", "Kapoor"));
        Console.WriteLine(Join("Raveena", 1011));
        Console.WriteLine(Join(0.438434, 1011));
    }

    /// <summary>
    /// Take 2 parameters and concatenates them with comma
    /// </summary>
    public static string Join<T1, T2>(T1 i, T2 j)
    {
        return i.ToString() + ',' + j.ToString();
    }

    // No need to create separate methods if we use Generics
    /*
    public static string Join(int i, int j)
    {
        return i.ToString() + ',' + j.ToString();
    }

    public static string Join2(double i, double j)
    {
        return i.ToString() + ',' + j.ToString();
    }

    public static string Join3(string i, string j)
    {
        return i.ToString() + ',' + j.ToString();
    }
    */
}


public class MyDataStore<T> where T : class
{
    public void Add(T someObject)
    {
        // save to database
        Console.WriteLine("Student Saved successfully to db");
    }

    public void Remove(int id)
    {
        // delete record from database
        Console.WriteLine("Student Saved deleted from db");
    }

    public void Update(T obj)
    {

    }
}

// No need to create separate classes if we use Generics
/*
public class MyDataStoreForStudent
{
    public void Add(Student student)
    {
        // save to database
        Console.WriteLine("Student Saved successfully to db");
    }

    public void Remove(int id)
    {
        // delete record from database
        Console.WriteLine("Student Saved deleted from db");
    }
}

public class MyDataStoreForTeacher
{
    public void Add(Teacher teacher)
    {
        // save to database
        Console.WriteLine("Teacher Saved successfully to db");
    }

    public void Remove(int id)
    {
        // delete record from database
        Console.WriteLine("Teacher Saved deleted from db");
    }
}
*/