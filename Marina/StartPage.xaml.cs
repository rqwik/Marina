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
                TextColor = Color.Tomato,
                BackgroundColor = Color.Violet
            };
            Button Timer_btn = new Button
            {
                Text = "Ava Timer leht",
                TextColor = Color.Tomato,
                BackgroundColor = Color.Violet
            };
            Button Box_btn = new Button
            {
                Text = "Ava BoxView leht",
                TextColor = Color.Tomato,
                BackgroundColor = Color.Violet
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn, Timer_btn, Box_btn },
                BackgroundColor = Color.Yellow
            };
            Content = st;
            Entry_btn.Clicked += Entry_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
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