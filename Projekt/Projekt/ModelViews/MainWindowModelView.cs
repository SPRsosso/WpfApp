using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Projekt.Commands;

namespace Projekt.ModelViews
{
    public class MainWindowModelView : INotifyPropertyChanged
    {
        public MainWindowModelView()
        {
            NWDCommand = new RelayCommand(NWD);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int arg1;
        public int Arg1
        {
            get { return arg1; }
            set
            {
                arg1 = value;
                OnPropertyChanged(nameof(Arg1));
            }
        }
        private int arg2;
        public int Arg2
        {
            get { return arg2; }
            set
            {
                arg2 = value;
                OnPropertyChanged(nameof(Arg2));
            }
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
        public ICommand NWDCommand { get; set; }
        public void NWD(Object obj)
        {
            try
            {
                int a = Convert.ToInt32(Arg1);
                int b = Convert.ToInt32(Arg2);
                while(a != b)
                {
                    if(a > b)
                    {
                        a -= b;
                    }
                    if(b > a)
                    {
                        b -= a;
                    }
                }

                Header = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
