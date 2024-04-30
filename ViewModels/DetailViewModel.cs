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
using WorkoutLogV1.Views;

namespace WorkoutLogV1.ViewModels
{
    //[QueryProperty(nameof(DetailedTraining),"DetailTraining")]
    public partial class DetailViewModel : ObservableObject, IQueryAttributable
    {
        [ObservableProperty]
        Training detailedTraining;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            DetailedTraining = query["DetailTraining"] as Training;
            OnPropertyChanged(nameof(DetailedTraining));
        }

        public DetailViewModel()
        {
        }
    }
}
