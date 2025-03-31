using NativeDesktopAppOpenFarm.ViewModels;
using System;
using System.Collections.Generic;

namespace NativeDesktopAppOpenFarm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int _selectedTabIndex;
        private ViewModelBase _currentViewModel;

        public MainWindowViewModel()
        {
            // Default to the Home tab
            SelectedTabIndex = 0;
            UpdateCurrentViewModel();
        }

        public int SelectedTabIndex
        {
            get => _selectedTabIndex;
            set
            {
                if (SetProperty(ref _selectedTabIndex, value))
                {
                    UpdateCurrentViewModel();
                }
            }
        }

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            private set => SetProperty(ref _currentViewModel, value);
        }

        private void UpdateCurrentViewModel()
        {
            switch (SelectedTabIndex)
            {
                case 0:
                    CurrentViewModel = new PlaceholderViewModel("Home");
                    break;
                case 1:
                    CurrentViewModel = new PlaceholderViewModel("Queue");
                    break;
                case 2:
                    CurrentViewModel = new PlaceholderViewModel("Printers");
                    break;
                case 3:
                    CurrentViewModel = new PlaceholderViewModel("Stats");
                    break;
                case 4:
                    CurrentViewModel = new PlaceholderViewModel("Messages");
                    break;
                case 5:
                    CurrentViewModel = new PlaceholderViewModel("Users");
                    break;
                case 6:
                    CurrentViewModel = new PlaceholderViewModel("Config");
                    break;
                default:
                    CurrentViewModel = new PlaceholderViewModel("Home");
                    break;
            }
        }
    }

    // Temporary ViewModel
    public class PlaceholderViewModel : ViewModelBase
    {
        private string _pageName;

        public string PageName
        {
            get => _pageName;
            private set => SetProperty(ref _pageName, value);
        }

        public PlaceholderViewModel(string pageName)
        {
            PageName = pageName;
        }
    }
}