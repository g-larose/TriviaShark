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

		private bool _isDrawerOPen;
		public bool IsDrawerOpen
		{
			get => _isDrawerOPen;
			set => OnPropertyChanged(ref _isDrawerOPen, value);
		}

        public AppViewModel(INavigator navigator)
        {
            _navigator = navigator;
            ExitAppCommand = new RelayCommand(ExitApp);
           
        }

        private void ExitApp()
        {
            App.Current.Shutdown();
        }

    }
}
