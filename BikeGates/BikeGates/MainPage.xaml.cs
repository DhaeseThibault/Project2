using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BikeGates.Views;

namespace BikeGates
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // When pressed on button => go to the page
            TapGestureRecognizer recognizer = new TapGestureRecognizer();
            recognizer.Tapped += OpenPlayMenu;
            btnPlay.GestureRecognizers.Add(recognizer);

            recognizer.Tapped += OpenLeaderboardMenu;
            btnLeaderboard.GestureRecognizers.Add(recognizer);
        }

        private void OpenLeaderboardMenu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeaderboardParkour());
        }

        private void OpenPlayMenu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoiceGamemode());
        }
    }
}
