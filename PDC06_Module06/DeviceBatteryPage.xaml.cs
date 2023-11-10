﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace PDC06_Module06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceBatteryPage : ContentPage
    {
        public DeviceBatteryPage()
        {
            InitializeComponent();
            SetBackground(Battery.ChargeLevel, 
                Battery.State == BatteryState.Charging);
        }

        void SetBackground (double level, bool charging)
        {
            Color? color = null;
            var status = charging ? "Charging" : "not Charging";
            if (level > 0.5f) 
            {
                color = Color.Green.MultiplyAlpha(level);
            }

            else if (level > .1f)
            {
                color = Color.DarkOrange.MultiplyAlpha(level);
            }

            else
            {
                color = Color.DarkRed.MultiplyAlpha(level);
            }

            BackgroundColor = color.Value;
            LabelBatteryLevel.Text = status;

        }

        void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            SetBackground(e.ChargeLevel, e.State == BatteryState.Charging);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged -= Battery_BatteryInfoChanged;
        }
    }
}