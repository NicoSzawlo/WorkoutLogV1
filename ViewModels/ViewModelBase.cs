using Microsoft.Maui.Layouts;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutLogV1.Models;

namespace WorkoutLogV1.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {
        public List<WeightTraining> WeightTrainings = new List<WeightTraining>();
        public List<CardioTraining> CardioTrainings = new List<CardioTraining>();


    }
}
