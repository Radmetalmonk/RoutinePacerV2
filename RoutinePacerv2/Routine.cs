using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutinePacerv1
{
    public class Routine
    {

        string _name;
        List<Activity> _activityList;

        // Constructor sets name and initializes list
        public Routine(string name)
        {
            _name = name;
            _activityList = new List<Activity>();
        }

        // Name of Routine
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // List of Activities within the Routine
        public List<Activity> ActivityList
        {
            get { return _activityList; }
            set { _activityList = value; }
        }
    }
}
