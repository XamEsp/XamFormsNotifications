using Rg.Plugins.Popup.Extensions;
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
            //var notification = DependencyService.Get<INotification>();


            //notification.Show("Test notification",NotificationType.Information);

            Device.BeginInvokeOnMainThread(async () =>
            {
                var n = new Notification(DateTime.Now.ToFileTimeUtc().ToString());
                await Navigation.PushPopupAsync(n);
            });


        }

      private async void Button_ChildClicked(object sender, EventArgs e)
      {
            //var notification = DependencyService.Get<INotification>();


            //notification.Show("Test notification",NotificationType.Information);

            var n = new XamFormsNotifications.ChildView();
            await Navigation.PushAsync(n);
        }
   }
}
