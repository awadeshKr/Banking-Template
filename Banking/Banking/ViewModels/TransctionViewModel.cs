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
    public class TransctionViewModel: INotifyPropertyChanged
    {
        private List<Transction> _transctionList;


        public  List<Transction> TransctionList
        {
            get { return _transctionList; }
            set
            {
                _transctionList = value;
                OnPropertyChanged();
            }
        }
        public TransctionViewModel()
        {
            InitilizeDataAsync();
        }

        public async Task InitilizeDataAsync()
        {
            var transctionService = new TransctionService();
            TransctionList =await transctionService.GetTransctionsAsync();
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
