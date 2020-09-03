using System;
using BookKeeping.Model;
using BookKeeping.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookKeeping
{
    public partial class App : Application
    {
        public static Constants Databse = new Constants();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BookKeepingView());
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
