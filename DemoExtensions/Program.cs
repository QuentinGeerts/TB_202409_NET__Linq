using DemoLambda;

//Int32Extensions int32 = new Int32Extensions();

Console.WriteLine("Veuillez entrez un nombre :");

if (int.TryParse(Console.ReadLine(), out int number))
{
    // Vérifier si le nombre est pair ou impair
    Console.WriteLine($"{number} est {(number.IsEven() ? "pair" : "impair")}");

    // Calculer le carré
    Console.WriteLine($"Le carré de {number} est: {number.Square()}");

    // Vérifier si le nombre est premier
    Console.WriteLine($"{number} est {(number.IsPrime() ? "premier" : "non premier")}");

    try
    {
        Console.WriteLine($"La factoriel de {number} est: {number.Factorial()}");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}
else
{
    Console.WriteLine("Veuillez entrer un nombre entier.");
}