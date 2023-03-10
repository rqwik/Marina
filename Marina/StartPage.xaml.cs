using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Marina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            //InitializeComponent();

            Button Entry_btn = new Button
            {
                Text = "Ava Entry leht",
                TextColor = Color.Black,
                BackgroundColor = Color.RosyBrown
            };
            Button Timer_btn = new Button
            {
                Text = "Ava Timer leht",
                TextColor = Color.Black,
                BackgroundColor = Color.RosyBrown
            };
            Button Box_btn = new Button
            {
                Text = "Ava BoxView leht",
                TextColor = Color.Black,
                BackgroundColor = Color.RosyBrown
            };
            Button Valg_btn = new Button
            {
                Text = "Valgusfoor",
                TextColor = Color.Black,
                BackgroundColor = Color.RosyBrown
            };
            Button Grid_btn = new Button
            {
                Text = "Grid",
                TextColor = Color.Black,
                BackgroundColor = Color.RosyBrown
            };
            Button Image_btn = new Button
            {
                Text = "Photo",
                TextColor = Color.Black,
                BackgroundColor = Color.RosyBrown
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn, Timer_btn, Box_btn, Valg_btn, Grid_btn, Image_btn},
                BackgroundColor = Color.Bisque
            };
            Content = st;
            Entry_btn.Clicked += Entry_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
            Valg_btn.Clicked += Valg_btn_Clicked;
            Grid_btn.Clicked += Grid_btn_Clicked;
            Image_btn.Clicked += Image_btn_Clicked;
        }

        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_Page());
        }

        private async void Grid_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid_Page());
        }

        private async void Valg_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor_Page());
        }

        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_Page());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Entry_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}