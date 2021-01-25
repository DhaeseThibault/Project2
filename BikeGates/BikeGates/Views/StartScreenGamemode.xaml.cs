using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeGates.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartScreenGamemode : ContentPage
    {
        public StartScreenGamemode()
        {
            InitializeComponent();

            string gamemode = ChoiceGamemode.listMode[0].ToString();
            string name1 = ChoicePlayer.listNames[0].ToString();

            lblName.Text = name1;

            if (gamemode == "Parkour")
            {
                lblObjectiveText.Text = "You have to drive between the cones that light up. When a cone is green you get 3 points, when it is orange you get 2 points and when it is red you don't get any points. Collect as many points as possible during the 2-minute time period.";
            }
            else if (gamemode == "Time Race")
            {
                lblObjectiveText.Text = "You have to drive between the cones that light up. You have to drive the track as fast as possible and whoever is the fastest wins.";
            }
            else if (gamemode == "Survival")
            {
                lblObjectiveText.Text = "You have to drive between the cones that light up. In time you will have to go faster once you don't pass through a cone in time you are out. You have to survive as long as possible on the track.";
            }
        }

        private void GoCountdownScreen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CountdownScreen());
        }

        private void btnGoBack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReviewPage());
        }
    }
}