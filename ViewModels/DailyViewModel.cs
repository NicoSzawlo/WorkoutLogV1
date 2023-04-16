using Microsoft.Maui.Layouts;
using CommunityToolkit.Maui.Views;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkoutLogV1.Models;
using WorkoutLogV1.Views;
using System.Collections.ObjectModel;

namespace WorkoutLogV1.ViewModels
{
    public class DailyViewModel : ViewModelBase
    {
        public ObservableRangeCollection<WeightTraining> DailyList { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public DailyViewModel()
        {
            Title = "Daily Page";
            AddWorkoutCommand = new MvvmHelpers.Commands.Command(AddWorkout);
            RefreshCommand = new AsyncCommand(Refresh);
            DailyList = new ObservableRangeCollection<WeightTraining>
            {
                new WeightTraining { Name = "Squats" },
                new WeightTraining { Name = "Deadlifts" },
                new WeightTraining { Name = "Military Press" },
                new WeightTraining { Name = "Barbell Rows" },
                new WeightTraining { Name = "Dumbbell Lunges" },
                new WeightTraining { Name = "Cable Flyes" },
                new WeightTraining { Name = "Incline Bench Press" },
                new WeightTraining { Name = "Seated Leg Press" },
                new WeightTraining { Name = "Hammer Curls" },
                new WeightTraining { Name = "Lat Pulldowns" },
                new WeightTraining { Name = "Tricep Pushdowns" },
                new WeightTraining { Name = "Bicep Curls" },
                new WeightTraining { Name = "Calf Raises" },
                new WeightTraining { Name = "Plank Hold" },
                new WeightTraining { Name = "Russian Twists" },
                new WeightTraining { Name = "Bent O231ver Rows" },
                new WeightTraining { Name = "Lat P12ulldowns" },
                new WeightTraining { Name = "Trice2p2 Pushdowns" },
                new WeightTraining { Name = "Bicep 123Curls" },
                new WeightTraining { Name = "Calf 12Raises" },
                new WeightTraining { Name = "Plank 23Hold" },
                new WeightTraining { Name = "Russian12 Twists" },
                new WeightTraining { Name = "Bent Ov12er Rows" }
            };
            
        }
        

        string testText = "Test 123 123";
        public string TestText
        {
            get => testText;
            set => SetProperty(ref testText, value);
        }

        string addName = "-";
        public string AddName
        {
            get => addName;
            set => SetProperty(ref addName, value);
        }
        public ICommand AddWorkoutCommand { get; }
        void AddWorkout()
        {
            WeightTraining exc = new WeightTraining() { Name = AddName };
            DailyList.Add(exc);
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }
    }
}
