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
        public AddEntryViewModel() 
        { 
            ExecuteAdd = new AsyncComma
        }
        private Training _training;

        public Training Training
        {
            get => _training;
            set
            {
                SetProperty(ref _training, value);
            }
        }

        string _name = "-";
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public ICommand ExecuteAdd { get; }
        void AddTraining()
        {
            Training training = new Training() { Name = _name };
            WeakReferenceMessenger.Default.Send(new AddTrainingMessage(training));
            await GoBack();
        }

    }
    
    
}
