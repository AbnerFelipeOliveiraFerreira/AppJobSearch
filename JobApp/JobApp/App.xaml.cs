﻿using Xamarin.Forms;

namespace JobApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (App.Current.Properties.ContainsKey("User"))
            {
                MainPage = new NavigationPage(new Views.Start());
            }
            else
            {
                MainPage = new NavigationPage(new Views.Login());
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
