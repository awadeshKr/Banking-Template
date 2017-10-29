using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Banking
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void ViewTransctionButton_OnClicked(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new Banking.Views.TransctionPage(),true);
        }
        private async void ViewBalanceButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Banking.Views.BalancePage(), true);
        }
        
    }
}
