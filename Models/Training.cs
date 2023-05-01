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
        public bool IsRepetetiveWorkout;

        //Public Properties
        public DateOnly Date { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        //Interface implementations
        
        private List<WeightExercise> sets;
        private TimeSpan duration;
        private double distance;
        public List<WeightExercise> Sets {
            get
            {
                if (IsRepetetiveWorkout)
                {
                    return sets;
                }
                else
                {
                    throw new InvalidOperationException("Error: this is not a Weight workout");
                }
            }
            set
            {
                if (IsRepetetiveWorkout)
                {
                    sets = value;
                }
                else
                {
                    throw new InvalidOperationException("Error: this is not a Cardioworkout");
                }
            }
        }
        public TimeSpan Duration
        {
            get
            {
                if (!IsRepetetiveWorkout)
                {
                    return duration;
                }
                else
                {
                    throw new InvalidOperationException("Error: this is not a Cardioworkout");
                }
            }
            set 
            {
                if (!IsRepetetiveWorkout)
                {
                    duration = value;
                }
                else
                {
                    throw new InvalidOperationException("Error: this is not a Cardioworkout");
                }
            }
        }
        public double Distance {
            get
            {
                if (!IsRepetetiveWorkout)
                {
                    return distance;
                }
                else
                {
                    throw new InvalidOperationException("Error: this is not a Cardioworkout");
                }
            }
            set
            {
                if (!IsRepetetiveWorkout)
                {
                    distance = value;
                }
                else
                {
                    throw new InvalidOperationException("Error: this is not a Cardioworkout");
                }
            }
        }
    }
}
