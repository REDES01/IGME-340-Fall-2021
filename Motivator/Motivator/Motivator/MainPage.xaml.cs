using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Motivator
{
    public partial class MainPage: ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BackgroundColor = Color.Black;
            var myLabel = new Label();
            myLabel.Text = "Motivator!";
            myLabel.TextColor = Color.White;
            myLabel.FontSize = 50;
            myLabel.HorizontalOptions = LayoutOptions.Center;
            mainGrid.Children.Add(myLabel, 0, 0);

            var myButton = new Button();
            myButton.Text = "Exercise!";
            myButton.TextColor = Color.Black;
            myButton.FontSize = 35;
            //myButton.HorizontalOptions = LayoutOptions.Center;
            myButton.Clicked+=async (sends, args)=> sayingLabel.Text = "Exercise and you will be fit!";
            mainGrid.Children.Add(myButton, 0, 3);
        }

        async void Button_Clicked(object sender,EventArgs args)
        {
            sayingLabel.Text = "Eat Veggies and you will lose weight!";
        }
    }
}
