using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriviaShark.Commands;
using TriviaShark.Interfaces;
using TriviaShark.Services;

namespace TriviaShark.ViewModels
{
    public class AppViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
		public ICommand ExitAppCommand { get; }
        public ICommand NavigateDashboardCommand { get; }

        public ViewModelBase? SelectedViewModel => _navigator.CurrentViewModel;
        public ViewModelBase? CurrentViewModel { get; set; }

		private bool _isDrawerOPen;
		public bool IsDrawerOpen
		{
			get => _isDrawerOPen;
			set => OnPropertyChanged(ref _isDrawerOPen, value);
		}

        public AppViewModel(INavigator navigator)
        {
            _navigator = navigator;
            _navigator.CurrentViewModelChanged += OnSelectedViewModelChanged;
            NavigateDashboardCommand = new NavigateCommand<DashboardViewModel>(_navigator, () => new DashboardViewModel(_navigator, this));
            ExitAppCommand = new RelayCommand(ExitApp);
           
        }

        private void OnSelectedViewModelChanged()
        {
            OnPropertyChanged(nameof(SelectedViewModel));
            IsDrawerOpen = false;
        }

        private void ExitApp()
        {
            App.Current.Shutdown();
        }

    }
}
