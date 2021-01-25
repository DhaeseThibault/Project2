using BikeGates.Models;
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
    public partial class ChoicePlayer : ContentPage
    {
        public static List<string> listNames { get; set; } = new List<string>();
        public static List<string> listAmount { get; set; } = new List<string>();

        public ChoicePlayer()
        {
            InitializeComponent();
        }

        private void imgBackBtn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoiceGamemode());
        }


        private void btnReview(object sender, EventArgs e)
        {
            listNames.Clear();
            listAmount.Clear();
            string value = lblSlider.Text;

            listAmount.Add(value);

            if (value == "1")
            {
                if (Name1.Text != null)
                {
                    listNames.Add(Name1.Text);
                    Navigation.PushAsync(new ReviewPage());
                }
                else
                {
                    DisplayAlert("Alert", "Please enter name", "ok");
                }
            }
            else if (value == "2")
            {
                if (Name1.Text != null && Name2.Text != null)
                {
                    listNames.Add(Name1.Text);
                    listNames.Add(Name2.Text);
                    Navigation.PushAsync(new ReviewPage());
                }
                else
                {
                    DisplayAlert("Alert", "Please enter name", "ok");
                }
            }
            else if (value == "3")
            {
                if (Name1.Text != null && Name2.Text != null && Name3.Text != null)
                {
                    listNames.Add(Name1.Text);
                    listNames.Add(Name2.Text);
                    listNames.Add(Name3.Text);
                    Navigation.PushAsync(new ReviewPage());
                }
                else
                {
                    DisplayAlert("Alert", "Please enter name", "ok");
                }
            }
            else if (value == "4")
            {
                if (Name1.Text != null && Name2.Text != null && Name3.Text != null && Name4.Text != null)
                {
                    listNames.Add(Name1.Text);
                    listNames.Add(Name2.Text);
                    listNames.Add(Name3.Text);
                    listNames.Add(Name4.Text);
                    Navigation.PushAsync(new ReviewPage());
                }
                else
                {
                    DisplayAlert("Alert", "Please enter name", "ok");
                }
            }
            else if (value == "5")
            {
                if (Name1.Text != null && Name2.Text != null && Name3.Text != null && Name4.Text != null && Name5.Text != null)
                {
                    listNames.Add(Name1.Text);
                    listNames.Add(Name2.Text);
                    listNames.Add(Name3.Text);
                    listNames.Add(Name4.Text);
                    listNames.Add(Name5.Text);
                    Navigation.PushAsync(new ReviewPage());
                }
                else
                {
                    DisplayAlert("Alert", "Please enter name", "ok");
                }
            }            
        }

        private void SliderValue_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // Saves the value of the slider
            string value = lblSlider.Text;

            // if the value of the slider is 1 then you show only the first entry and boxview etc...
            if (value == "1")
            {
                Name1.IsVisible = true;
                Name1B.IsVisible = true;
                Name2.IsVisible = false;
                Name2B.IsVisible = false;
                Name3.IsVisible = false;
                Name3B.IsVisible = false;
                Name4.IsVisible = false;
                Name4B.IsVisible = false;
                Name5.IsVisible = false;
                Name5B.IsVisible = false;
            }
            else if (value == "2")
            {
                Name1.IsVisible = true;
                Name1B.IsVisible = true;
                Name2.IsVisible = true;
                Name2B.IsVisible = true;
                Name3.IsVisible = false;
                Name3B.IsVisible = false;
                Name4.IsVisible = false;
                Name4B.IsVisible = false;
                Name5.IsVisible = false;
                Name5B.IsVisible = false;

            }
            else if (value == "3")
            {
                Name1.IsVisible = true;
                Name1B.IsVisible = true;
                Name2.IsVisible = true;
                Name2B.IsVisible = true;
                Name3.IsVisible = true;
                Name3B.IsVisible = true;
                Name4.IsVisible = false;
                Name4B.IsVisible = false;
                Name5.IsVisible = false;
                Name5B.IsVisible = false;
            }
            else if (value == "4")
            {
                Name1.IsVisible = true;
                Name1B.IsVisible = true;
                Name2.IsVisible = true;
                Name2B.IsVisible = true;
                Name3.IsVisible = true;
                Name3B.IsVisible = true;
                Name4.IsVisible = true;
                Name4B.IsVisible = true;
                Name5.IsVisible = false;
                Name5B.IsVisible = false;
            }
            else if (value == "5")
            {
                Name1.IsVisible = true;
                Name1B.IsVisible = true;
                Name2.IsVisible = true;
                Name2B.IsVisible = true;
                Name3.IsVisible = true;
                Name3B.IsVisible = true;
                Name4.IsVisible = true;
                Name4B.IsVisible = true;
                Name5.IsVisible = true;
                Name5B.IsVisible = true;
            }
        }
    }
}