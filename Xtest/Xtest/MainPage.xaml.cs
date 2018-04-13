using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;




namespace Xtest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //button.Text = "Generate Crash";
            //button.Clicked += CreateCrash;
            handledExButton.Text = "Generate a Handled Exception";
            handledExButton.Clicked += CreateHandledError;
        }

        private void CreateHandledError(object sender, EventArgs e)
        {
            try
            {
                int a=1;
                int result = a / 0;
                
            }
            catch (Exception exception)
            {
                var properties = new Dictionary<string, string> {
                    { "Category", "Music" },
                    { "Wifi", "On" }
                };
                Crashes.TrackError(exception, properties);
            }
        }

        private void CreateCrash(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }
    }
}
