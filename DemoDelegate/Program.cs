using DemoDelegate.Models;

NotificationService ns = new NotificationService();

// Impossible d'instancier car classe statique
// Notification notification = new Notification();

// Enregistrer des méthodes de notification personnalisées
ns.RegisterNotification(Notification.SendEmail);
ns.RegisterNotification(Notification.SendPigeon);
ns.RegisterNotification(Notification.SendSms);

// Envoyer les notifications
ns.Notify("Hello World!");

// Désenregistrement d'une méthode de notification
ns.UnregisterNotification(Notification.SendPigeon);

// Envoyer les notifications
ns.Notify("Hello World virtuellement!");

/*
 * Délégué générique
 * Action<T[, ...]>        → Ne retourne pas de valeur
 * Func<[T, ...]TResult>   → Retourne une valeur
 */

// Func<typeA, typeB, typeResult>
Func<int, int, int> add = Mathematic.Add;
int sum = add(10, 20);

// Action<string>

Action<string> sayHello = (message) => Console.WriteLine(message);
Action<string> sayGoodbye = delegate (string message) { Console.WriteLine(message); };
sayHello("Hello World!");
sayGoodbye("Good by ! ");

