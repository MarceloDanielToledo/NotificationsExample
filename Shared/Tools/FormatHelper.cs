namespace NotificationsExample.Shared.Tools
{
    public static class FormatHelper
    {
        public static string GetMessage(string message, int limit)
        {
            if (message.Length > limit)
            {
                var _message = message.Substring(0, limit - 3);
                return _message + "...";

            }
            return message;

        }
    }
}
