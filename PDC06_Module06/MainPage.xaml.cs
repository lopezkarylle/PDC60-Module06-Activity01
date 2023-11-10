using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PDC06_Module06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AccelerometerPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccelorometerPage());
        }

        private async void ConnectivityPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectivityPage());
        }

        private async void DeviceBatteryPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeviceBatteryPage());
        }

        private async void GeolocationPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeolocationPage());
        }

    }
}
