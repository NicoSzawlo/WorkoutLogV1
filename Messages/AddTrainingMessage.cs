using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutLogV1.Models;

namespace WorkoutLogV1.Messages
{
    public class AddTrainingMessage : ValueChangedMessage<Training>
    {
        public AddTrainingMessage(Training training) : base(training)
        {
        }
        
    }
}
