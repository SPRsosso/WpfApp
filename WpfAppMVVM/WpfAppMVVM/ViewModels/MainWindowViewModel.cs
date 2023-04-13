using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppMVVM.Commands;

namespace WpfAppMVVM.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        

        public MainWindowViewModel() {

            IloczynCommand = new RelayCommand(iloczyn);
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string header;

        public string Header
        {
            get { return header; }
            set
            {
                header = value;
                OnPropertyChanged(nameof(Header));
            }
        }

        private string arg1;

        public string Arg1
        {
            get { return arg1; }
            set { arg1 = value; 
                OnPropertyChanged(nameof(Arg1));
            }
        }
        private string arg2;

        public string Arg2
        {
            get { return arg2; }
            set
            {
                arg2 = value;
                OnPropertyChanged(nameof(Arg2));
            }
        }

        public ICommand IloczynCommand { get; set; }

        public void iloczyn(Object obj)
        {
            try
            {
                double x = Convert.ToDouble(Arg1);
                double y = Convert.ToDouble(Arg2);
                double w = x * y;
                Header = w.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        
    }
}
