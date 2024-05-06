using CommunityToolkit.Maui.Views;
using WorkoutLogV1.Models;
using WorkoutLogV1.Views;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.ComponentModel;
using WorkoutLogV1.Messages;
using CommunityToolkit.Mvvm.Input;

namespace WorkoutLogV1.ViewModels
{
    public partial class DetailWeightTrainingViewModel : ObservableObject, IQueryAttributable
    {
        [ObservableProperty]
        WeightTraining detailedTraining;

        AddSetPopup popup;
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            DetailedTraining = query["DetailTraining"] as WeightTraining;
            OnPropertyChanged(nameof(DetailedTraining));
        }
        [RelayCommand]
        async Task NewSet()
        {
            await Shell.Current.ShowPopupAsync(popup);
        }

        public DetailWeightTrainingViewModel()
        {
        }
    }
}
