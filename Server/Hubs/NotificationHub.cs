using Microsoft.AspNetCore.SignalR;

namespace NotificationsExample.Server.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task Send(string notificationSerialized)
        {
            await Clients.All.SendAsync("ReceiveNotifications", notificationSerialized);
        }
    }
}
