using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;
using System.Timers;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace XamFormsNotifications
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notification : PopupPage
    {

        private Timer _timer;

        public Notification(string message)
        {
            InitializeComponent();

            _timer = new Timer();

            _timer.Interval = 2000;
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();

            MessageLabel.Text = message;
        }

        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PopPopupAsync();
            });
        }
    }
}