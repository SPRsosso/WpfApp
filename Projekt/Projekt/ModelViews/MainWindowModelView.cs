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
        private string arg1;
        public string Arg1
        {
            get { return arg1; }
            set
            {
                arg1 = value;
                OnPropertyChanged(nameof(Arg1));
            }
        }
        public string Arg2
        {
            get { return arg2; }
            set
            {
                arg2 = value;
                OnPropertyChanged(nameof(Arg2));
            }
        }
        public ICommand NWDCommand { get; set; }
        public void NWD(Object obj)
        {
            try
            {
                while(Arg1 != Arg2)
                {
                    if(Arg1 > Arg2)
                    {
                        Arg1 = Arg1 - Arg2;
                    }
                    if(obj > Arg1)
                    {
                        Arg2 = Arg2 - Arg1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
