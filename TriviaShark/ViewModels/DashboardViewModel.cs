using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriviaShark.Commands;
using TriviaShark.Interfaces;

namespace TriviaShark.ViewModels
{
    public class DashboardViewModel: ViewModelBase
    {
       
        private readonly INavigator _navigator;
        public ICommand NavigateBackCommand { get; }
        public ICommand GetQuestionsCommand { get; }
        public DashboardViewModel(INavigator navigator, ViewModelBase? currentVM)
        {
            _navigator = navigator;
            GetQuestionsCommand = new RelayCommand(GetQuestions);
            //NavigateBackCommand = new NavigateCommand<>(_navigator, () => new currentVM(_navigator));
        }

        private void GetQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
