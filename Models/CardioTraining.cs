﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogV1.Models
{
    public class CardioTraining : Training
    {
        public TimeSpan Duration { get; set; }
        public double Distance { get; set; }
    }
}
