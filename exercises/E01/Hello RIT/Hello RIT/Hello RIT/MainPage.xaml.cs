using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hello_RIT
{
    public partial class MainPage: ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var topLabel = new Label();
            var bottomLabel = new Label();

            topLabel.Text = "Hello";
            topLabel.FontSize = 36;
            mainStack.Children.Add(topLabel);

            topLabel.Margin = new Thickness(100, 40, 0, 0);

            bottomLabel.Text = "RIT";
            bottomLabel.FontSize = 48;
            bottomLabel.HorizontalTextAlignment = TextAlignment.Center;
            mainStack.Children.Add(bottomLabel);
            BackgroundColor = Color.Orange;

            var nameLabel = new Label();
            nameLabel.Text = "Xuanang Zhao";
            nameLabel.FontSize = 20;
            nameLabel.HorizontalTextAlignment = TextAlignment.Center;
            nameLabel.VerticalOptions = LayoutOptions.EndAndExpand;
            nameLabel.Margin = new Thickness(0, 0, 0, 50);
            mainStack.Children.Add(nameLabel);


            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += async (s, e) => {

                await topLabel.TranslateTo(100, 500, 1000, Easing.BounceOut);

            };

            tapGestureRecognizer.Tapped += async (s, e) => {
                await nameLabel.ScaleTo(2.0, 200, Easing.BounceIn);

            };
            tapGestureRecognizer.Tapped += async (s, e) => {
                await bottomLabel.RotateTo(200);

            };
            mainStack.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
