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
    public partial class Grid_Page : ContentPage
    {
        Frame fr;
        Label lbl;
        Grid gr;

        public Grid_Page()
        {
            lbl = new Label
            {
                Text = "Raami kujundus",
                FontSize = Device.GetNamedSize(NamedSize.Subtitle, typeof(Label))
            };
            gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1, GridUnitType.Star)},//цифра обозначает размер квадратика
                    new RowDefinition{Height=new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1, GridUnitType.Star)}
                },
            };
            fr = new Frame
            {
                Content = gr,
                BorderColor = Color.FromRgb(20, 120, 255),
                CornerRadius = 20,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            gr.Children.Add(new BoxView { Color = Color.Blue }, 0, 0);
            gr.Children.Add(new BoxView { Color = Color.Indigo }, 1, 0);
            gr.Children.Add(new BoxView { Color = Color.IndianRed }, 0, 1);
            gr.Children.Add(new BoxView { Color = Color.GreenYellow }, 1, 1);
            gr.Children.Add(new BoxView { Color = Color.Purple }, 0, 2);
            gr.Children.Add(new BoxView { Color = Color.Pink }, 1, 2);

            StackLayout st = new StackLayout
            {
                Children = { lbl, fr }
            };
            Content = st;
        }
    }
}

