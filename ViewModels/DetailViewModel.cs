using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutLogV1.Messages;
using WorkoutLogV1.Models;
using WorkoutLogV1.Services;
using WorkoutLogV1.Views;

namespace WorkoutLogV1.ViewModels
{
    [QueryProperty(nameof(DetailTraining),"DetailTraining")]
    public partial class DetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Training _detailTraining;
        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            WeakReferenceMessenger.Default.Register<OpenTrainingMessage>(this, (r, m) =>
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Open(m.Value);
                });
            });
        }

        private void Open(Training training)
        {
            DetailTraining = training;
        }
    }
}
