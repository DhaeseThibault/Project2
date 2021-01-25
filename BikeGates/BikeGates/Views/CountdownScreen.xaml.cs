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
    public partial class CountdownScreen : ContentPage
    {
        private int _countSeconds = 5;

        public CountdownScreen()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds--;
                if (_countSeconds == 0)
                {
                    CountLabel.Text = "GO!";
                    return Convert.ToBoolean(_countSeconds);
                }
                else
                {
                    CountLabel.Text = _countSeconds.ToString();
                    return Convert.ToBoolean(_countSeconds);
                }
            });
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(5500);

            if (ChoiceGamemode.listMode[0] == "Parkour")
            {
               await this.Navigation.PushAsync(new GameScreenParkour());
            }
            else if (ChoiceGamemode.listMode[0] == "Time Race")
            {
                await this.Navigation.PushAsync(new GameScreenTimeRace());
            }
            else if (ChoiceGamemode.listMode[0] == "Survival")
            {
                await this.Navigation.PushAsync(new GameScreenSurvival());
            }
        }

        private void GoScreenParkour(object sender, EventArgs e)
        {
            
        }
    }
}