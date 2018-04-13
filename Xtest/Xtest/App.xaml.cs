using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

using Xamarin.Forms;

namespace Xtest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Xtest.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.LogLevel = LogLevel.Verbose;
            AppCenter.Start("android=xxxxxx-6d89-4a67-a40c-bef540761c5b;", typeof(Analytics), typeof(Crashes), typeof(Push));
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
