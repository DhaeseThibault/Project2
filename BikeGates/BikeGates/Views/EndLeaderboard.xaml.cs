using BikeGates.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeGates.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EndLeaderboard : ContentPage
    {
        private ObservableCollection<ItemsList> thpendingorders;
        private ObservableCollection<ItemsList> pendingorders;
        int x = 0;
        public EndLeaderboard()
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
            thpendingorders.Add(new ItemsList() { Name = "Laurens", Score = 4 });

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

        private void OpenMainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}