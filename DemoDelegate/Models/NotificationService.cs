namespace DemoDelegate.Models;

// Définition du délégué pour les méthodes de notifications
public delegate void NotificationDelegate(string message);

public class NotificationService
{
    // Délégué pour le méthodes de notifications
    NotificationDelegate notificationDelegate;
    // Action<string> notificationDelegateAction;

    public void RegisterNotification(NotificationDelegate method)
    {
        notificationDelegate += method;
    }

    public void UnregisterNotification(NotificationDelegate method)
    {
        notificationDelegate -= method;
    }

    public void Notify(string message)
    {
        notificationDelegate?.Invoke(message);
        // if (notificationDelegate != null) notificationDelegate(message);
    }
}