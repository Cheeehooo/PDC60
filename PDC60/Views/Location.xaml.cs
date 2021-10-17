using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Location : ContentPage
    {
        bool isGettingLocation;
        public Location()
        {
            InitializeComponent();
        }
        //Code para kumuha. Kaso continuous. Greedy fuck to eh. Jk
        async void Button_Clicked(System.Object sender, EventArgs e)
        {
            isGettingLocation = true;
            while (isGettingLocation)
            {
                var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));
                resultLocation.Text += $"lat: {result.Latitude}, lng: {result.Longitude}{Environment.NewLine}";
                await Task.Delay(1000);
            }
        }
        //Shempre eto stop. Di maganda sobra.
        void Stop_Clicked(System.Object sender, EventArgs e)
        {
            isGettingLocation = false;
        }
    }
}

//May error dito kase wala pang laman yung .xaml file.