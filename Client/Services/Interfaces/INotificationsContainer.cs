using NotificationsExample.Shared.Models;

namespace NotificationsExample.Client.Services.Interfaces
{
    public interface INotificationsContainer
    {
        List<Notification> Notifications { get; set; }
        void Add(Notification notification);
        void Remove(Notification notification);
        void Read(Notification notification);

        event Action StatusChanged;


    }
}
