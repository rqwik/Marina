using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Marina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lum_Page : ContentPage
    {
        BoxView box1, box2, box3, box4, silm1, silm2, suu, nina;
        Button btn, btn1, btn2, btn3;
        Label lbl;
        public Lum_Page()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            box1 = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 0,
                WidthRequest = 50,
                HeightRequest = 50,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            box2 = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 80,
                HeightRequest = 80,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            box3 = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 120,
                HeightRequest = 120,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            box4 = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 160,
                HeightRequest = 160,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };

            silm1 = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 100,
                WidthRequest = 10,
                HeightRequest = 10,
            };
            silm2 = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 100,
                WidthRequest = 10,
                HeightRequest = 10,
            };
            suu = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 0,
                WidthRequest = 30,
                HeightRequest = 5,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            nina = new BoxView
            {
                Color = Color.Orange,
                CornerRadius = 100,
                WidthRequest = 7,
                HeightRequest = 7,
            };

            btn = new Button
            {
                Text = "OFF",
            };
            btn.Clicked += Btn_Clicked;

            btn1 = new Button
            {
                Text = "ON",
            };
            btn1.Clicked += Btn1_Clicked;

            btn2 = new Button
            {
                Text = "Hide me",
            }; btn2.Clicked += Btn2_Clicked;

            btn3 = new Button
            {
                Text = "Random",
            }; btn3.Clicked += Btn3_Clicked;

            /*StackLayout stackLayout = new StackLayout()
            {
                Margin = 10,
                Spacing = -20,
                Children = { box1, box2, box3, box4 }
            };
            Content = stackLayout;

            StackLayout stackLayout1 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { btn, btn1, btn2, btn3 },
            };
            Content = stackLayout1;

            StackLayout stackLayout3 = new StackLayout()
            {
                Children = { stackLayout, stackLayout1 }
            };
            Content = stackLayout3;*/

            AbsoluteLayout.SetLayoutBounds(box1, new Rectangle(110, 75, 50, 50));
            absoluteLayout.Children.Add(box1);
            AbsoluteLayout.SetLayoutBounds(box2, new Rectangle(85, 100, 100, 100));
            absoluteLayout.Children.Add(box2);
            AbsoluteLayout.SetLayoutBounds(box3, new Rectangle(60, 165, 150, 150));
            absoluteLayout.Children.Add(box3);
            AbsoluteLayout.SetLayoutBounds(box4, new Rectangle(37, 265, 200, 200));
            absoluteLayout.Children.Add(box4);
            absoluteLayout.Children.Add(silm1, new Point(120, 140));
            absoluteLayout.Children.Add(silm2, new Point(140, 140));
            absoluteLayout.Children.Add(suu, new Point(120, 165));
            absoluteLayout.Children.Add(nina, new Point(132, 150));
            absoluteLayout.Children.Add(btn, new Point(10, 500));
            absoluteLayout.Children.Add(btn1, new Point(100, 500));
            absoluteLayout.Children.Add(btn2, new Point(190, 500));
            absoluteLayout.Children.Add(btn3, new Point(280, 500));
            Content = absoluteLayout;
        }
        Random rnd = new Random();
        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            Color randomColor = Color.FromRgb(r, g, b);

            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            Color randomColor1 = Color.FromRgb(r, g, b);

            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            Color randomColor2 = Color.FromRgb(r, g, b);

            box2.Color = randomColor;
            box3.Color = randomColor1;
            box4.Color = randomColor2;
        }
        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            box2.Opacity = 0.6;
            box3.Opacity = 0.6;
            box4.Opacity = 0.6;
            int i;
            for (i = 0; i <= 6; i++)
            {
                box2.Opacity -= 0.1;
                await Task.Run(() => Thread.Sleep(100));
                box3.Opacity -= 0.1;
                await Task.Run(() => Thread.Sleep(100));
                box4.Opacity -= 0.1;
                await Task.Run(() => Thread.Sleep(100));
            };
        }
        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            box4.Opacity = 1;
            box1.Opacity = 1;
            box2.Opacity = 1;
            box3.Opacity = 1;
        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            box4.Opacity = 0;
            box1.Opacity = 0;
            box2.Opacity = 0;
            box3.Opacity = 0;
        }
    }
}
