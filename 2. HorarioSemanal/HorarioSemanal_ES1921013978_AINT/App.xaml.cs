﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HorarioSemanal_ES1921013978_AINT.Vistas;

namespace HorarioSemanal_ES1921013978_AINT
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
