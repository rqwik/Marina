using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Button Ent_btn = new Button //будет кнопка
            {
                Text = "Ava Entry leht",
                TextColor = Color.DarkTurquoise,
                BackgroundColor = Color.BlueViolet
            };
            StackLayout st = new StackLayout //какое-то расположение кнопки
            {
                Orientation = StackOrientation.Vertical,
                Children = { Ent_btn },
                BackgroundColor = Color.GreenYellow
            };
            Content = st; // запускает
            Ent_btn.Clicked += Ent_btn_Clicked;
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}