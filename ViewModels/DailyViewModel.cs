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
    public partial class DailyViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Training> dailyList;
        [ObservableProperty]
        Training selectedTraining;

        AddEntryPopup popup;

        public DailyViewModel()
        {

            WeakReferenceMessenger.Default.Register<AddTrainingMessage>(this, (r, m) =>
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Add(m.Value);
                });
            });
            dailyList = new ObservableCollection<Training>
            {
                new WeightTraining { Name = "Squats", Sets = new List<WeightExercise> {
                    new() { Reps = 10, Weight = 19.5},
                    new() { Reps = 15, Weight = 25.3 } } },
                new CardioTraining { Name = "Run", Date = DateTime.Now, Duration = new TimeSpan(1,0,0), Distance=10}
            };
            popup = new AddEntryPopup(new AddEntryViewModel());
        }
        [RelayCommand]
        async Task OpenEntry(Training training)
        {
            if(training is WeightTraining) { await Shell.Current.GoToAsync(nameof(DetailWeightTrainingPage), new Dictionary<string, object> { { "DetailTraining", training } }); }
            else { await Shell.Current.GoToAsync(nameof(DetailCardioTrainingPage), new Dictionary<string, object> { { "DetailTraining", training } }); }
            
        }
        [RelayCommand]
        async Task NewEntry()
        {
            await Shell.Current.ShowPopupAsync(popup);
        }

        private void Add(Training training)
        {
            if (training == null)
            {
                throw new ArgumentNullException();
            }

            DailyList.Add(training);
        }
    }
}
