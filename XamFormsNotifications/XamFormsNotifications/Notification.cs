namespace XamFormsNotifications
{
   public interface INotification
   {
      void Show(string message, NotificationType notificationType);
   }

   public enum NotificationType
   {
      Success = 1,
      Error = 2,
      Information = 3
   }
}