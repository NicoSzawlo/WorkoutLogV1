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
    public partial class DetailCardioTrainingViewModel : ObservableObject,IQueryAttributable
    { 
        [ObservableProperty]
        CardioTraining detailedTraining;
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            DetailedTraining = query["DetailTraining"] as CardioTraining;
            OnPropertyChanged(nameof(DetailedTraining));
        }
        public DetailCardioTrainingViewModel() { }
    }
}
