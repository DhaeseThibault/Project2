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
    public partial class GameScreenParkour : ContentPage
    {
        private int _countSeconds = 120;

        public GameScreenParkour()
        {
            InitializeComponent();

            //Timer that counts down to 0
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds--;
                CountLabel.Text = _countSeconds.ToString();
                return Convert.ToBoolean(_countSeconds);
            });


            

            //Responsive name on top of the page
            string Players = ChoicePlayer.listAmount[0];
            int amount = EndScreenParkour.listTimesHere.Count();

            if (Players == "1")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "2")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "3")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 2)
                {
                    lblName.Text = ChoicePlayer.listNames[2].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = true;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "4")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 2)
                {
                    lblName.Text = ChoicePlayer.listNames[2].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = true;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 3)
                {
                    lblName.Text = ChoicePlayer.listNames[3].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = true;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "5")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 2)
                {
                    lblName.Text = ChoicePlayer.listNames[2].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = true;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 3)
                {
                    lblName.Text = ChoicePlayer.listNames[3].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = true;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 4)
                {
                    lblName.Text = ChoicePlayer.listNames[4].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = true;
                }
            }

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000);
            await this.Navigation.PushAsync(new EndScreenParkour());
        }
    }
}