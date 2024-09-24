namespace DemoLinq.Models;

public class Student : Person
{
    public Student(int id, string firstname, string lastname, double progress)
        : base(id, firstname, lastname)
    {
        Progress = progress;
    }

    public List<string> CourseEnrolled { get; set; } = new List<string>();
    public double Progress { get; set; }

    public override string ToString()
    {
        string courses = string.Join(", ", CourseEnrolled);
        return $"{base.ToString()}, Courses Enrolled [{courses}], Progress: {Progress:F2}%";
    }
}