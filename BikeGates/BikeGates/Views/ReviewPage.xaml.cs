using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BikeGates.Models;
using BikeGates.Views;


namespace BikeGates.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewPage : ContentPage
    {
        public ReviewPage()
        {
            InitializeComponent();

            lblGamemode.Text = ChoiceGamemode.listMode[0].ToString();
            string gamemode = ChoiceGamemode.listMode[0].ToString();

            // Review about the gamemode
            // Change the picture
            // Change the label and color
            if (gamemode == "Parkour")
            {
                lblGamemode.TextColor = Color.FromHex("#20BFA9");
                imgParkour.IsVisible = true;
                imgTimeRace.IsVisible = false;
                imgSurvival.IsVisible = false;
            }
            else if (gamemode == "Time Race")
            {
                lblGamemode.TextColor = Color.FromHex("#F2C8EE");
                imgParkour.IsVisible = false;
                imgTimeRace.IsVisible = true;
                imgSurvival.IsVisible = false;
            }
            else if (gamemode == "Survival")
            {
                lblGamemode.TextColor = Color.FromHex("#EE786C");
                imgParkour.IsVisible = false;
                imgTimeRace.IsVisible = false;
                imgSurvival.IsVisible = true;
            }

            // add the names to a list 
            if (ChoicePlayer.listAmount[0] == "1")
            {
                name1.Text = ChoicePlayer.listNames[0];
                name1B.IsVisible = true;
                name2B.IsVisible = false;
                name3B.IsVisible = false;
                name4B.IsVisible = false;
                name5B.IsVisible = false;
            }
            else if (ChoicePlayer.listAmount[0] == "2")
            {
                name1.Text = ChoicePlayer.listNames[0];
                name2.Text = ChoicePlayer.listNames[1];
                name1B.IsVisible = true;
                name2B.IsVisible = true;
                name3B.IsVisible = false;
                name4B.IsVisible = false;
                name5B.IsVisible = false;
            }
            else if (ChoicePlayer.listAmount[0] == "3")
            {
                name1.Text = ChoicePlayer.listNames[0];
                name2.Text = ChoicePlayer.listNames[1];
                name3.Text = ChoicePlayer.listNames[2];
                name1B.IsVisible = true;
                name2B.IsVisible = true;
                name3B.IsVisible = true;
                name4B.IsVisible = false;
                name5B.IsVisible = false;
            }
            else if (ChoicePlayer.listAmount[0] == "4")
            {
                name1.Text = ChoicePlayer.listNames[0];
                name2.Text = ChoicePlayer.listNames[1];
                name3.Text = ChoicePlayer.listNames[2];
                name4.Text = ChoicePlayer.listNames[3];
                name1B.IsVisible = true;
                name2B.IsVisible = true;
                name3B.IsVisible = true;
                name4B.IsVisible = true;
                name5B.IsVisible = false;
            }
            else if (ChoicePlayer.listAmount[0] == "5")
            {
                name1.Text = ChoicePlayer.listNames[0];
                name2.Text = ChoicePlayer.listNames[1];
                name3.Text = ChoicePlayer.listNames[2];
                name4.Text = ChoicePlayer.listNames[3];
                name5.Text = ChoicePlayer.listNames[4];
                name1B.IsVisible = true;
                name2B.IsVisible = true;
                name3B.IsVisible = true;
                name4B.IsVisible = true;
                name5B.IsVisible = true;
            }

        }

        private void imgBackBtn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoicePlayer());
        }

        private void GoStartParkour(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StartScreenGamemode());
        }

    }
}