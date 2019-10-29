using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BixbyLantern
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override async void OnStart()
        {
            await Flashlight.TurnOnAsync();
        }

        protected override async void OnSleep()
        {
            await Flashlight.TurnOffAsync();
        }

        protected override async void OnResume()
        {
            await Flashlight.TurnOnAsync();
        }
    }
}
