using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Marina
{
    public partial class Image_Page : ContentPage
    {
        Switch sw;
        Image img;

        public Image_Page()
        {
            img = new Image { Source = "lisa.jpeg" };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            tap.NumberOfTapsRequired = 2;
            img.GestureRecognizers.Add(tap);
            sw = new Switch
            {
                IsToggled = true,
                VerticalOptions = LayoutOptions.EndAndExpand,//kommi
                HorizontalOptions = LayoutOptions.Center
            };
            sw.Toggled += Sw_Toggled;
            this.Content = new StackLayout { Children = { img, sw } };
        }
        int tapid;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            tapid++;
            var imgsender = (Image)sender;
            if (tapid % 2 == 0)
            {
                img.Source = "lisa.jpeg";
            }
            else
            {
                img.Source = "rassvet.jpeg";
            }
        }
        private void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                img.IsVisible = true;
            }
            else
            {
                img.IsVisible = false;
            }
        }
    }
}