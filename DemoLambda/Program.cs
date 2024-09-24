delegate int Operation(int a, int b);

internal class Program
{
    public static void Main(string[] args)
    {
        Operation addition = (a, b) => a + b;
        Operation subtraction = delegate(int a, int b) { return a - b; };

        int a = 10;
        int b = 20;
        int result = addition(a, b);

        Console.WriteLine($"a = {a}, b = {b}, result = {result}");


        string[] formateurs =
        [
            "Quentin", "Aude", "Khun", "Sebastien",
            "Samuel", "Thierry", "Michael", "Mélanie",
            "Jérémy", "Romain", "Aurélien"
        ];

        foreach (string formateur in formateurs)
        {
            Console.WriteLine(formateur);
        }

        /*
         * Création de fonctions pour filtrer le tableau
         */

        Console.WriteLine("\nFormateurs avec plus de 5 lettres:");
        foreach (string formateur in FiltrerPlusDe5Lettres(formateurs))
        {
            Console.WriteLine(formateur);
        }
        
        Console.WriteLine("\nFormateurs commençant par A:");
        foreach (string formateur in FiltrerCommenceParA(formateurs))
        {
            Console.WriteLine(formateur);
        }
        
        Console.WriteLine("\nFormateurs contenant la lettre 'u':");
        foreach (string formateur in Filtrer(formateurs, f => f.Contains("u")))
        {
            Console.WriteLine(formateur);
        }
    }

    static string[] FiltrerPlusDe5Lettres(string[] formateurs)
    {
        List<string> formateursPlus5Lettres = new();
        foreach (string formateur in formateurs)
        {
            if (formateur.Length > 5) formateursPlus5Lettres.Add(formateur);
        }

        return formateursPlus5Lettres.ToArray();
    }

    static string[] FiltrerCommenceParA(string[] formateurs)
    {
        List<string> formateursCommenceParA = new();
        foreach (string formateur in formateurs)
        {
            if (formateur.StartsWith("A")) formateursCommenceParA.Add(formateur);
        }
        return formateursCommenceParA.ToArray();
    }

    static string[] Filtrer(string[] formateurs, Func<string, bool> predicate)
    {
        List<string> formateursFiltrer = new();

        foreach (string formateur in formateurs)
        {
            if (predicate(formateur)) formateursFiltrer.Add(formateur); 
        }
        
        return formateursFiltrer.ToArray();
    }
}