using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogV1.Models
{
    public class Exercise
    {
        public DateOnly Date { get; set; }
        public string Name { get; set; }
        public string SetsReps { get; set; }
        public string Weight { get; set; }
        public string Notes { get; set; }
    }
}
