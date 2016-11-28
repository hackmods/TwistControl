using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwistControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void SpinClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int colour = r.Next(1, 5);
            int sign = r.Next(1, 5);

            if (colour == 1)
                BackgroundColor = Color.FromHex("009b7b"); //green
            else if (colour == 2)
                BackgroundColor = Color.FromHex("fff217"); //yellow
            else if (colour == 3)
                BackgroundColor = Color.FromHex("0181c8"); //blue
            else
                BackgroundColor = Color.FromHex("ef2d23"); //red

            if (sign == 1)
            {
                imgMove.Source = "leftfoot.png";
                lblGame.Text = "Left Foot";
            }
            else if (sign == 2)
            {
                imgMove.Source = "rightfoot.png";
                lblGame.Text = "Right Foot";
            }
            else if (sign == 3)
            {
                imgMove.Source = "lefthand.png";
                lblGame.Text = "Left Hand";
            }
            else
            {
                imgMove.Source = "righthand.png";
                lblGame.Text = "Right Hand";
            }

        }

    }
}
