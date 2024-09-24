namespace DemoGeneric.Models;

public class PersonManager<T> where T : Person
{
    private readonly List<T> _person = new(); // Inférence de type depuis C# 9.0

    public void Add(T person)
    {
        _person.Add(person);
    }
}