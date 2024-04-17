using NotificationsExample.Client.Services.Interfaces;
using NotificationsExample.Shared.Models;

namespace NotificationsExample.Client.Services
{
    public class NotificationsContainer : INotificationsContainer
    {
        public List<Notification> Notifications { get; set; } = [];

        public event Action StatusChanged;

        public void Add(Notification notification)
        {
            Notifications.Add(notification);
            StatusChanged.Invoke();
        }

        public void Read(Notification notification)
        {
            var _notification = Notifications.Find(x => x.Id == notification.Id);
            if (_notification != null)
            {
                _notification.IsActive = false;
            }
            StatusChanged.Invoke();
        }

        public void Remove(Notification notification)
        {
            Notifications.Remove(notification);
            StatusChanged.Invoke();
        }
    }
}
