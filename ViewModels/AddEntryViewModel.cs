using WorkoutLogV1.Models;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using WorkoutLogV1.Messages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WorkoutLogV1.ViewModels
{
    public partial class AddEntryViewModel : ObservableObject
    {
        [ObservableProperty]
        DateOnly date;
        [ObservableProperty]
        string name;
        [ObservableProperty]
        string note;
        [ObservableProperty]
        double weight;
        [ObservableProperty]
        int reps;
        [ObservableProperty]
        TimeSpan time;
        [ObservableProperty]
        double distance;
        [ObservableProperty]
        bool isEndurance;
        [ObservableProperty]
        List<WeightExercise> weightExercises;

        public AddEntryViewModel()
        {
        }

        [RelayCommand]
        void AddTraining()
        {
            Training training = new Training() {
                Name = Name,
                Note = Note,
                Date = Date};
            WeakReferenceMessenger.Default.Send(new AddTrainingMessage(training));
        }

        [RelayCommand]
        void SwitchEndurance()
        {
            IsEndurance = !IsEndurance;
        }
        [RelayCommand]
        void AddSet()
        {
            //if (WeightExercises == null)
            //{
            //    WeightExercises = new List<WeightExercise>() { new WeightExercise() { Reps = this.Reps, Weight = this.Weight } };

            //}
            //else
            //{
            //    WeightExercises.Add(new WeightExercise() { Reps = this.Reps, Weight = this.Weight });
            //}
            
        }

    }
    
    
}
