using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Amiibopedia.App;

namespace Amiibopedia
{
    public partial class App : Application
    {
        public App()
        {

           

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
