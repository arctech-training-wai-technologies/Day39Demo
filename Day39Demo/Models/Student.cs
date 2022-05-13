namespace Day39Demo.Models;

public class Student
{
    public int Id { get; set; }

    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public string Email { get; set; }

    public string Telephone { get; set; }

    public override string ToString()
    {
        return $"{Id} | {RollNumber} | {Name} | {Age} | {Email} | {Telephone}";
    }
}
