using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogV1.Models
{
    public interface ICardioTraining
    {
        TimeSpan Duration { get; set; }
        double Distance { get; set; }
    }
}
