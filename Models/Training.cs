using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogV1.Models
{
    public class Training : ICardioTraining, IWeightTraining
    {
        //Configuration
        public bool IsEnduranceWorkout;

        //Public Properties
        public DateOnly Date { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        //Interface implementations
        
        private List<WeightExercise> sets;
        private TimeSpan duration;
        private double distance;
        public List<WeightExercise> Sets {
            get
            {
                    return sets;
            }
            set
            {
                    sets = value;
            }
        }
        public TimeSpan Duration
        {
            get
            {
                    return duration;
            }
            set 
            {
                    duration = value;
            }
        }
        public double Distance {
            get
            {
                    return distance;
            }
            set
            {
                    distance = value;
            }
        }
    }
}
