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
using WorkoutLogV1.Services;

namespace WorkoutLogV1.ViewModels
{
    public partial class DailyViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Training> dailyList;
        [ObservableProperty]
        Training selectedTraining;
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
                    new WeightExercise { Reps = 10, Weight = 19.5}, 
                    new WeightExercise { Reps = 15, Weight = 25.3 } } }
            };
        }
        [RelayCommand]
        async Task OpenEntry(Training training)
        {
            //This navigates to page
            //await Shell.Current.GoToAsync(nameof(DetailPage));

            await Shell.Current.GoToAsync(
                $"{nameof(DetailPage)}?DetailTraining={training}",
                true);

            //This doesnt navigate to page and throws: System.InvalidCastException: 'Object must implement IConvertible.'
                //await Task.Delay(200);
                //await Shell.Current.GoToAsync(
                //nameof(DetailPage),
                //true,
                //new Dictionary<string, object>()
                //{
                //    { "DetailTraining", (Training)training }
                //});
        }

        private void Add(Training training)
        {
            if (training == null) throw new ArgumentNullException();
            DailyList.Add(training);
        }
    }
}
