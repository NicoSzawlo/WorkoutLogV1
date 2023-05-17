using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogV1.Models
{
    public partial class Training
    {
        public DateOnly Date { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        [RelayCommand]
        public void OpenDetail()
        {

        }
    }
}
