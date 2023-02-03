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
    public partial class Entry_Page : ContentPage
    {
        Editor ed;//когда-то будет такая переменная
        Button btn;
        public Entry_Page()
        {
            ed = new Editor
            {
                Placeholder = "Sisesta siia tekst",
                BackgroundColor = Color.Brown,
                TextColor = Color.Plum
            };
            btn = new Button
            {
                Text = "Tagasi",
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { ed , btn }, //отображает на странице данные переменные
                BackgroundColor = Color.Pink,
            };
            Content= st;
            btn.Clicked += btn_Clicked;

        }
        private async void btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}