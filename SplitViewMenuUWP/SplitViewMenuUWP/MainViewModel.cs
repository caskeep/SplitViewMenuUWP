using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SplitViewMenu;
using SplitViewMenuUWP.Scenario1;

namespace SplitViewMenuUWP
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            MenuItems = new ObservableCollection<SimpleNavMenuItem>();
            InitialPage = typeof (Scenario1Page1);
        }

        public ObservableCollection<SimpleNavMenuItem> MenuItems { get; }

        public Type  InitialPage { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}