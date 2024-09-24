
using System.Collections;
using DemoLinq.Models;

ArrayList persons =
[
    new Coach(1, "Quentin", "Geerts")
    {
        SubjectsTaught = new List<string> { "Angular", "C#", "SQL", "PHP" },
    },
    new Coach(2, "Michaël", "Person")
    {
        SubjectsTaught = new List<string> { "C#", "WCF", "SQL Server", "SignalR" },
    },
    new Student(3, "Aude", "Beurive", 75.0)
    {
        CourseEnrolled = new List<string> { "Angular", "React" },
    },
    new Student(4, "Aurélien", "Strimelle", 50.0)
    {
        CourseEnrolled = new List<string> { "React", ".NET", "Android" },
    },
    new Student(5, "Khun", "Ly", 30.0)
    {
        CourseEnrolled = new List<string> { "Angular", "C#", "SQL", "Ionic" },
    },
    new Coach(6, "Mélanie", "Geerts")
    {
        SubjectsTaught = new List<string> { "Scrum", "BPMN", "UML", "WordPress" },
    },
    new Student(7, "Laurent", "Fontaine", 85.0)
    {
        CourseEnrolled = new List<string> { "Scrum", "BPMN", "SQL", "MS Project" },
    },
    new Student(8, "Samuel", "Legrain", 90.0)
    {
        CourseEnrolled = new List<string> { "C#", "SQL Server", "HTML/CSS", "Javascript" },
    },
    new Coach(9, "Thierry", "Morre")
    {
        SubjectsTaught = new List<string> { "C#", "Design Pattern", "WPF / MVVM" },
    },
    new Student(10, "Jérémy", "Bazin", 60.0)
    {
        CourseEnrolled = new List<string> { "Python", "C#" },
    }
];