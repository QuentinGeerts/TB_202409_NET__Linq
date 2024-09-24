using DemoGeneric.Models;

PersonManager<Student> studentManager = new();
PersonManager<Teacher> teacherManager = new();

PersonManager<Person> personManager = new();

// PersonManager<int> intManager = new(); // Ne fonctionne pas car int n'est pas une personne <!>

studentManager.Add(new Student("Eva", 28, "1234567890"));
studentManager.Add(new Student("Dylan", 29, "0987654321"));
teacherManager.Add(new Teacher("Quentin", 28, "345876543234"));

personManager.Add(new Student("Eva", 28, "1234567890"));
personManager.Add(new Student("Dylan", 29, "0987654321"));
personManager.Add(new Teacher("Quentin", 28, "345876543234"));