using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogV1.Services
{
    public class NavigationService : INavigationService
    {
        Task INavigationService.NavigateToAsync(string route, IDictionary<string, object> parameters)
        {
            if(parameters != null)
                return Shell.Current.GoToAsync(route,parameters);
            else
                return Shell.Current.GoToAsync(route);
        }
    }
}
