using Microsoft.Maui.Layouts;
using CommunityToolkit.Maui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
        private ObservableCollection<Training> _dailyList;
        public ObservableCollection<Training> DailyList { get => _dailyList; set => SetProperty(ref _dailyList, value); }
        public DailyViewModel()
        {

            WeakReferenceMessenger.Default.Register<AddTrainingMessage>(this, (r, m) =>
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Add(m.Value);
                });
            });
            DailyList1 = new ObservableCollection<Training>
            {
                new Training { Name = "Squats", Sets = new List<WeightExercise> { new WeightExercise { Reps = 10, Weight = 19.5}, new WeightExercise { Reps = 15, Weight = 25.3 } } },
                new Training { Name = "Deadlifts" },
                new Training { Name = "Military Press" },
                new Training { Name = "Barbell Rows" },
                new Training { Name = "Dumbbell Lunges" },
                new Training { Name = "Cable Flyes" },
                new Training { Name = "Incline Bench Press" },
                new Training { Name = "Seated Leg Press" },
                new Training { Name = "Hammer Curls" },
                new Training { Name = "Lat Pulldowns" },
                new Training { Name = "Tricep Pushdowns" },
                new Training { Name = "Bicep Curls" },
                new Training { Name = "Calf Raises" },
                new Training { Name = "Plank Hold" },
                new Training { Name = "Russian Twists" },
                new Training { Name = "Bent O231ver Rows" },
                new Training { Name = "Lat P12ulldowns" },
                new Training { Name = "Trice2p2 Pushdowns" },
                new Training { Name = "Bicep 123Curls" },
                new Training { Name = "Calf 12Raises" },
                new Training { Name = "Plank 23Hold" },
                new Training { Name = "Russian12 Twists" },
                new Training { Name = "Bent Ov12er Rows" }
            };

        }
        void Add(Training training)
        {
            if (training == null) throw new ArgumentNullException();
            DailyList1.Add(training);
        }

        string testText = "Test 123 123";
        public string TestText
        {
            get => testText;
            set => SetProperty(ref testText, value);
        }
        public ObservableCollection<Training> DailyList1 { get => _dailyList; set => _dailyList = value; }
    }
}
