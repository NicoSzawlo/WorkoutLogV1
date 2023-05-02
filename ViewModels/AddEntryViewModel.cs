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
        string name;
        [ObservableProperty]
        string description;

        public AddEntryViewModel()
        {
        }

        [RelayCommand]
        void AddTraining()
        {
            Training training = new Training() { Name = this.Name };
            WeakReferenceMessenger.Default.Send(new AddTrainingMessage(training));
        }

    }
    
    
}
