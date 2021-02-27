using ExpenseTracker.Pages;
using Xamarin.Forms;

namespace ExpenseTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TestView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
