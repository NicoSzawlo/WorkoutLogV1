using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutLogV1.Messages;
using WorkoutLogV1.Models;
using WorkoutLogV1.Views;

namespace WorkoutLogV1.ViewModels
{
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        Training detailTraining;
        public DetailViewModel()
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
