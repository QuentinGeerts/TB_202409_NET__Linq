namespace DemoGeneric.Models;

public class Teacher : Person
{
    public Teacher(string name, int age, string employeId) : base(name, age)
    {
        EmployeId = employeId;
    }

    public string EmployeId { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Employe Id: {EmployeId}";
    }
}