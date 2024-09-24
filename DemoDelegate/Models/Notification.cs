namespace DemoDelegate.Models;

public static class Notification
{
    // Définition des différentes méthodes de notification
    public static void SendEmail(string message)
    {
        Console.WriteLine($"Envoi d'email: {message}");
    }

    public static void SendSms(string message)
    {
        Console.WriteLine($"Envoi d'sms: {message}");
    }

    public static void SendPigeon(string message)
    {
        Console.WriteLine($"Envoi d'pigeon: {message}");
    }
}