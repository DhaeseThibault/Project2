﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BikeGates.Views;

namespace BikeGates
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ChoicePlayer();
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
