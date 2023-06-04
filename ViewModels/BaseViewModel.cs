using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutLogV1.Services;

namespace WorkoutLogV1.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        protected readonly INavigationService NavigationService;
        public BaseViewModel(INavigationService navigationService) 
        { 
            NavigationService = navigationService;
        }
    }
}
