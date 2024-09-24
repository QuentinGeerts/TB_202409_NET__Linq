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
    },
    // new { Firstname = "Quentin", Age = 28 }
];

/*
 * Opérateur Cast<T>()
 * Convertir tous les éléments de la collection en une séquence de type "T"
 */

Console.WriteLine("\nOpérateurs Cast<T>()");
IEnumerable<Person> personsCastAsPersons = persons.Cast<Person>();
foreach (var person in personsCastAsPersons)
{
    Console.WriteLine(person);
}

Console.WriteLine("\nExpression de requête Cast");
IEnumerable<Person> personsCastAsPersonsQE = from Person person in persons select person;
foreach (var person in personsCastAsPersonsQE)
{
    Console.WriteLine(person);
}

/*
 * Opérateur OfType<T>()
 * Filtrer une collection pour obtenir uniquement les éléments de type "T"
 */

Console.WriteLine("\nOpérateur OfType<T>()");
IEnumerable<Person> personsOfTypePerson = persons.OfType<Person>();
var coaches = persons.OfType<Coach>();
IEnumerable<Student> students = persons.OfType<Student>();

Console.WriteLine("\nListe des personnes:");
foreach (var person in personsOfTypePerson)
{
    Console.WriteLine(person);
}

Console.WriteLine("\nListe des coaches:");
foreach (var person in coaches)
{
    Console.WriteLine(person);
}

Console.WriteLine("\nListe des étudiants:");
foreach (var person in students)
{
    Console.WriteLine(person);
}

// <!>: L'expression de requête pour OfType<T> n'existe pas
Console.WriteLine("\nExpression de requête OfType:");
IEnumerable<Coach> coachesOfTypeExpression = from c in persons.OfType<Coach>() select c;

/*
 * Opérateur Where<TSource>( Func< TSource, bool >() )
 * Filtrer la séquence sur base d'une condition
 */

var coachesTaughtCSharp = persons
    .OfType<Coach>()
    .Where(c => c.SubjectsTaught.Contains("C#"));

Console.WriteLine("\nListe des coaches qui donnent C#:");
foreach (var coach in coachesTaughtCSharp)
{
    Console.WriteLine(coach);
}

var studentsCourseCSharp = persons
    .OfType<Student>()
    .Where(s => s.CourseEnrolled.Contains("C#"));

Console.WriteLine("\nListe des coaches qui suivent C#:");
foreach (var person in studentsCourseCSharp)
{
    Console.WriteLine(person);
}

var personsCSharp = persons
    .OfType<Person>()
    .Where<Person>(p => (
        (p is Coach coach && (coach.SubjectsTaught.Contains("C#")
                              || coach.SubjectsTaught.Contains("Scrum")))
        || (p is Student s && s.CourseEnrolled.Contains("C#"))
    ));

Console.WriteLine("\nListe des personnes qui donnent ou suivent C#:");
foreach (var person in personsCSharp)
{
    Console.WriteLine(person);
}

Console.WriteLine("\nExpression de requête Where:");
var studentsLearnSQL = from s in persons.OfType<Student>()
    where s.CourseEnrolled.Exists(s => s.Contains("SQL"))
    select s;

Console.WriteLine("\nListe des students qui suivent SQL:");
foreach (var student in studentsLearnSQL)
{
    Console.WriteLine(student);
}

/*
 * Opérateur Select()
 */

IEnumerable<string> fullnames = persons
    .Cast<Person>()
    .Select(person => person.Firstname + " " + person.Lastname);

Console.WriteLine("\nNoms complets des personnes:");
foreach (string fullname in fullnames)
{
    Console.WriteLine(fullname);
}

var personsDetails = persons
    .OfType<Person>()
    .Select(p => new { Id = p.Id, PersonFullName = p.Firstname + " " + p.Lastname });

Console.WriteLine("\nListe des personnes:");
foreach (var personsDetail in personsDetails)
{
    Console.WriteLine(personsDetail);
    Console.WriteLine(personsDetail.Id);
    Console.WriteLine(personsDetail.PersonFullName);
}