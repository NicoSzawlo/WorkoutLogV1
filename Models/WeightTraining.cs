using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogV1.Models
{
    public class WeightTraining : Training
    {
        public List<WeightTraining> Sets { get; set; }
    }
    public class WeightExercise
    {
        public int Reps { get; set; }
        public double Weight { get; set; }
    }
}
