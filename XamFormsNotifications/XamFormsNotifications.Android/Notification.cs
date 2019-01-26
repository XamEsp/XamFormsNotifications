using System;
using Android.Content;
using Android.Content.Res;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace XamFormsNotifications.Droid
{
   // http://blog.infernored.com/going-native-using-android-views-in-xamarin-forms
   // https://developer.android.com/guide/topics/ui/notifiers/toasts
   public class Notification : INotification
   {
      private static Context _context;

      public static void Init(Context context)
      {
         _context = context;
      }

      public void Show(string message, NotificationType notificationType)
      {
         if (_context == null)
            throw new NullReferenceException(
               "You need to call the Init method before trying to use the Notification.Show method");

         var view = View.Inflate(_context, Resource.Layout.Notification , null);
         var text = view.FindViewById<TextView>(Resource.Id.text);
         text.Text = message;

         var toast = new Toast(_context)
         {
            Duration = ToastLength.Long,
            View = view
         };
         toast.SetGravity(GravityFlags.Bottom,0,0);
         toast.Show();
      }
   }
}