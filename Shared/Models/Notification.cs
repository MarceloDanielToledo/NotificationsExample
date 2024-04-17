using MudBlazor;
using NotificationsExample.Shared.Enums;

namespace NotificationsExample.Shared.Models
{
    public class Notification
    {
        public Guid Id { get; set; } = Guid.Empty;
        public EnumNotificationTypes NotificationType { get; set; }

        public string NotificationIcon
        {
            get
            {
                return NotificationType switch
                {
                    EnumNotificationTypes.NewMessage => Icons.Material.Filled.Message,
                    EnumNotificationTypes.OrderUpdated => Icons.Material.Filled.Whatshot,
                    EnumNotificationTypes.ProductUpdated => Icons.Material.Filled.ProductionQuantityLimits,
                    EnumNotificationTypes.PricesUpdated => Icons.Material.Filled.PriceChange,
                    EnumNotificationTypes.ServiceMessage => Icons.Material.Filled.NetworkCheck,
                    _ => string.Empty
                };
            }
        }
        public Color NotificationColor
        {
            get
            {
                return NotificationType switch
                {
                    EnumNotificationTypes.NewMessage => Color.Primary,
                    EnumNotificationTypes.OrderUpdated => Color.Secondary,
                    EnumNotificationTypes.ProductUpdated => Color.Info,
                    EnumNotificationTypes.PricesUpdated => Color.Tertiary,
                    EnumNotificationTypes.ServiceMessage => Color.Warning,
                    _ => Color.Success
                };
            }

        }

        public string Message { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public bool IsActive { get; set; } = true;

        public string TimeSinceEventFormatted
        {
            get
            {
                var timeSinceEvent = DateTime.Now - DateTimeStamp;

                if (timeSinceEvent.TotalSeconds < 60)
                    return $"{timeSinceEvent.Seconds} seconds ago";
                if (timeSinceEvent.TotalMinutes < 60)
                    return $"{timeSinceEvent.Minutes} minutes ago";
                if (timeSinceEvent.TotalHours < 24)
                    return $"{timeSinceEvent.Hours} hours ago";
                if (timeSinceEvent.TotalDays < 7)
                    return $"{timeSinceEvent.Days} days ago";
                if (timeSinceEvent.TotalDays < 30)
                    return $"{timeSinceEvent.Days / 7} weeks ago";
                if (timeSinceEvent.TotalDays < 365)
                    return $"{timeSinceEvent.Days / 30} months ago";
                return $"{timeSinceEvent.Days / 365} years ago";
            }
        }
    }
}
