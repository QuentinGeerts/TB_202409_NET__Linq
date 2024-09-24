int[] numbers = [1, 2, 3, 4, 5];


/*
 * Exécution immédiate
 */

Console.WriteLine($"Nombre d'éléments: {numbers.Count()}");

/*
 * Exécution différée
 */

var evenNumbers = numbers.Where(x => x % 2 == 0);

numbers[1] = 6; // Modification de la source de données avant l'exécution dans le foreach

foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}

/*
 * Explication avec le Yield
 */

Console.WriteLine("\nForeach sans yield return");
foreach (var number in GetNumbers(3))
{
    Console.WriteLine(number);
}

Console.WriteLine("\nForeach avec yield return");
foreach (var number in GetNumbersYield(3))
//foreach (var number in GetNumbersYield(3).ToArray()) // A quoi ça sert ? A rien
{
    Console.WriteLine(number);
}

static List<int> GetNumbers(int count)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < count; i++)
    {
        numbers.Add(i);
    }
    return numbers;
}

static IEnumerable<int> GetNumbersYield(int count)
{
    for (int i = 0; i < count; i++)
    {
        yield return i; // Retourne l'élément et suspend l'exécution
    }
}