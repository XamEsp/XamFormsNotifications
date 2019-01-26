using System;
using Xamarin.Forms;

namespace XamFormsNotifications
{
   public partial class MainPage : ContentPage
   {
      public MainPage()
      {
         InitializeComponent();
      }

      private void Button_OnClicked(object sender, EventArgs e)
      {
         var notification = DependencyService.Get<INotification>();


         notification.Show("Test notification",NotificationType.Information);
      }
   }
}
