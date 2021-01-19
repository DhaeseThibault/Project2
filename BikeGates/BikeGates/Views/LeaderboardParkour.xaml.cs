using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BikeGates.Models;

namespace BikeGates.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaderboardParkour : ContentPage
    {
        private ObservableCollection<ItemsList> thpendingorders;
        private ObservableCollection<ItemsList> pendingorders;
        int x = 0;

        public LeaderboardParkour()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            //   await _connection.CreateTableAsync<TH_PENDING_ORDERS>();
            //   var porders = await _connection.Table<TH_PENDING_ORDERS>().ToListAsync();
            thpendingorders = new ObservableCollection<ItemsList>();
            thpendingorders.Add(new ItemsList() { Name = "Thibault", Score = 1 });
            thpendingorders.Add(new ItemsList() { Name = "Henri", Score = 1 });
            thpendingorders.Add(new ItemsList() { Name = "Niels", Score = 2 });
            thpendingorders.Add(new ItemsList() { Name = "Robin", Score = 3 });
            thpendingorders.Add(new ItemsList() { Name = "Glenn", Score = 4 });
            thpendingorders.Add(new ItemsList() { Name = "Wout", Score = 5 });
            thpendingorders.Add(new ItemsList() { Name = "NielsO", Score = 6 });
            thpendingorders.Add(new ItemsList() { Name = "Ward", Score = 7 });
            thpendingorders.Add(new ItemsList() { Name = "Alexander", Score = 8 });
            thpendingorders.Add(new ItemsList() { Name = "Laurens", Score = 9 });
            pendingorders = new ObservableCollection<ItemsList>();
            lvwLeaderboard.ItemsSource = pendingorders;
            foreach (var i in thpendingorders)
            {
                int z = 0;
                string dno = i.Name;
                int tno = i.Score;

                if (tno > 0)
                {
                    //await Task.Delay(1000);
                    pendingorders.Add(new ItemsList { Name = dno, Score = tno });
                }

            }

            base.OnAppearing();
        }
    }
}