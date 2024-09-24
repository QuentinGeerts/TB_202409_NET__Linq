namespace DemoLinq.Models;

public class Coach : Person
{
    public Coach(int id, string firstname, string lastname)
        : base(id, firstname, lastname)
    {
    }

    public List<string> SubjectsTaught { get; set; } = new();

    public override string ToString()
    {
        string subjects = string.Join(", ", SubjectsTaught);
        return $"{base.ToString()}, Subjects taught: [{subjects}]";
    }
}