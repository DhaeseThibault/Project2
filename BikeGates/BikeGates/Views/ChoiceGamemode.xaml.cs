using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BikeGates.Models;

namespace BikeGates.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoiceGamemode : ContentPage
    {
        public static List<string> listMode { get; set; } = new List<string>();

        public ChoiceGamemode()
        {
            InitializeComponent();

            
        }

        private void GoChoicePlayer(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoicePlayer());
        }

        private void imgBackBtn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        public void AddParkourListGoNextPage(object sender, EventArgs e)
        {
            listMode.Clear();
            listMode.Add("Parkour");            

            Navigation.PushAsync(new ChoicePlayer());
        }

        public void AddTimeRaceListGoNextPage(object sender, EventArgs e)
        {
            listMode.Clear();
            listMode.Add("Time Race");            


            Navigation.PushAsync(new ChoicePlayer());
        }

        public void AddSurvivalListGoNextPage(object sender, EventArgs e)
        {
            listMode.Clear();
            listMode.Add("Survival");

            Navigation.PushAsync(new ChoicePlayer());
        }
    }
}