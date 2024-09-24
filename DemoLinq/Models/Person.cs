namespace DemoLinq.Models;

public class Person
{
    public Person(int id, string firstname, string lastname)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
    }
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public override string ToString()
    {
        return $"{Id} {Firstname} {Lastname}";
    }
}