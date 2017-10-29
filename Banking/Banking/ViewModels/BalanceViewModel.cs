using Banking.Models;
using Banking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banking.ViewModels
{
    public class BalanceViewModel : INotifyPropertyChanged
    {
        private Balance _balance;
        public Balance Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                OnPropertyChanged();
            }
        }

        public BalanceViewModel()
        {
            var balanceService = new BalanceService();
            Balance = balanceService.GetBalance();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
