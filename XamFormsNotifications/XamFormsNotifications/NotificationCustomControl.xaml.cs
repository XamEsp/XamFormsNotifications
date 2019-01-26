using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsNotifications
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotificationCustomControl : ContentView
	{
		public NotificationCustomControl ()
		{
			InitializeComponent ();
		}

	   #region Message

	   public static readonly BindableProperty MessageProperty = BindableProperty.Create(
	      "Message",
	      typeof(string),
	      typeof(NotificationCustomControl),
	      string.Empty);

	   public string Message
	   {
	      get => (string)GetValue(MessageProperty);
	      set => SetValue(MessageProperty, value);
	   }

	   #endregion

   }
}