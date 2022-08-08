using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningPage
{
    public partial class App : Application
    {
        public Color BarBackgroundColor { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            {
                BarBackgroundColor = Color.Green;
            }
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
