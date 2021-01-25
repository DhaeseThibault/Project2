using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BikeGates.Models;
using BikeGates.Repositories;

namespace BikeGates.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaderboardParkour : ContentPage
    {
        public LeaderboardParkour()
        {
            InitializeComponent();
            //TestWeatherRepository();
        }

        private async void TestWeatherRepository()
        {
            List<Parkour> list = await BikeGatesRepository.GetParkour();
            lvwLeaderboard.ItemsSource = list;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }


        private ObservableCollection<ItemsList> thpendingorders;
        private ObservableCollection<ItemsList> pendingorders;
        //int x = 0;

        protected async override void OnAppearing()
        {
            List<Parkour> list = await BikeGatesRepository.GetParkour();
            //var sorted = list.OrderBy(y => y.Points.ToString());



            thpendingorders = new ObservableCollection<ItemsList>();
            thpendingorders.Add(new ItemsList() { Rank = "1.",  Name = list[0].Name,  Score = list[0].Points});
            thpendingorders.Add(new ItemsList() { Rank = "2.",  Name = list[1].Name,  Score = list[1].Points});
            thpendingorders.Add(new ItemsList() { Rank = "3.",  Name = list[2].Name,  Score = list[2].Points});
            thpendingorders.Add(new ItemsList() { Rank = "4.",  Name = list[3].Name,  Score = list[3].Points});
            thpendingorders.Add(new ItemsList() { Rank = "5.",  Name = list[4].Name,  Score = list[4].Points});
            thpendingorders.Add(new ItemsList() { Rank = "6.",  Name = list[5].Name,  Score = list[5].Points});
            thpendingorders.Add(new ItemsList() { Rank = "7.",  Name = list[6].Name,  Score = list[6].Points});
            thpendingorders.Add(new ItemsList() { Rank = "8.",  Name = list[7].Name,  Score = list[7].Points});
            thpendingorders.Add(new ItemsList() { Rank = "9.",  Name = list[8].Name,  Score = list[8].Points});
            thpendingorders.Add(new ItemsList() { Rank = "10.", Name = list[9].Name,  Score = list[9].Points});
            thpendingorders.Add(new ItemsList() { Rank = "11.", Name = list[10].Name, Score = list[10].Points});
            pendingorders = new ObservableCollection<ItemsList>();
            

            lvwLeaderboard.ItemsSource = pendingorders;


            int x = 0;
            foreach (var i in thpendingorders)
            {
                string name = i.Name;
                string rank = i.Rank;
                int points = i.Score;
                if (x < 10)
                {
                    pendingorders.Add(new ItemsList { Rank = rank, Name = name, Score = points});
                }
                x++;
            }
            base.OnAppearing();

        }
    }
}