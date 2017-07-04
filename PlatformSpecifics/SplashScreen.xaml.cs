using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlatformSpecifics
{
    public partial class SplashScreen
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(500);

            Application.Current.MainPage = new PlatformSpecificsPage();
        }
    }
}
