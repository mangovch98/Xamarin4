﻿using app.ViewModels;
using app.Views;
using Paises.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainViewModel = MainViewModel.GetInstance();	
            mainViewModel.Lands = new PaisViewModel();	

            this.MainPage = new NavigationPage(new PaisPage()); 
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}