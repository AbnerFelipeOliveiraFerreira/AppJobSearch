﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JobApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Register(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }

        private void btn_Start(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Start());
        }
    }
}