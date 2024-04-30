using WorkoutLogV1.Models;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using WorkoutLogV1.Messages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using CommunityToolkit.Maui.Views;

namespace WorkoutLogV1.ViewModels
{
    public partial class AddEntryViewModel : ObservableObject
    {
        [ObservableProperty]
        DateTime trainDate;
        [ObservableProperty]
        string trainName;
        [ObservableProperty]
        string trainNote;
        [ObservableProperty]
        double trainWeight;
        [ObservableProperty]
        int trainReps;
        [ObservableProperty]
        TimeSpan trainStart;
        [ObservableProperty]
        TimeSpan trainEnd;
        [ObservableProperty]
        double trainDistance;
        [ObservableProperty]
        bool trainIsEndurance;

        public AddEntryViewModel()
        {
            trainDate = DateTime.Now;
        }

        [RelayCommand]
        void AddTraining(object obj)
        {
            Training training= new Training();
            if (!TrainIsEndurance)
            {
                training = new WeightTraining()
                {
                    Name = TrainName,
                    Note = TrainNote,
                    Date = TrainDate,
                    Sets = new List<WeightExercise> { new WeightExercise { Reps = TrainReps, Weight = TrainWeight } }
                };
            }
            else
            {
                TimeSpan duration = TrainEnd - TrainStart;
                training = new CardioTraining()
                {
                    Name = TrainName,
                    Note = TrainNote,
                    Date = TrainDate,
                    Duration = duration,
                    Distance = TrainDistance
                };
            }
            WeakReferenceMessenger.Default.Send(new AddTrainingMessage(training));
            if (obj is Popup popup)
            {
                popup.Close();
            }
        }

        [RelayCommand]
        void SwitchEndurance()
        {
            TrainIsEndurance = !TrainIsEndurance;
        }
    }
    
    
}
