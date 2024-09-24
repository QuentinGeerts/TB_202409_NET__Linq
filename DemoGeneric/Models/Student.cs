namespace DemoGeneric.Models;

public class Student : Person
{
    public Student(string name, int age, string studentNumber) : base(name, age)
    {
        StudentNumber = studentNumber;
    }

    public string StudentNumber { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Student number: {StudentNumber}";
    }
}