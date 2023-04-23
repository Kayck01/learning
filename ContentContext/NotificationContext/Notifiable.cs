using System.Collections.Generic;
namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
           Notifications = new List<Notification>();
        }
        public void AddNotidication(Notification notifications)
        {
            Notifications.Add(notifications);
        }

           public void AddNotidication(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    
        public bool IsInvalid => Notifications.Any();
    }

}