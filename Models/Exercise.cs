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
        public List<(int,double)> Sets { get; set; } //Contains number of reps and weight
        public string Notes { get; set; }
    }
}
