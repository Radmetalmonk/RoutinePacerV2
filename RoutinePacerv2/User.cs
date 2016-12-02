using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace RoutinePacerv1
{
    [Serializable]
    public class User
    {
        // Name of the user
        string _name;
        // List of non-active routines
        List<Routine> _routineList;
        // List of active routines
        List<ActiveRoutine> _activeRoutineList;
        
        // Using the activity list from a routine,
        // Create active routine with a start date,
        // end date, and rollover time.
        // Adds it to the list.
        public void ActivateRoutine(Routine R, DateTime start, DateTime end, DateTime rollover)
        {
            // Create new active routine with parameters
            ActiveRoutine ar = new ActiveRoutine(R.Name, start, end, rollover);

            // Create active activity list for new active routine
            List<ActiveActivity> alist = new List<ActiveActivity>();
            foreach (Activity a in R.ActivityList)
            {
                alist.Add(new ActiveActivity(a.Name, Convert.ToInt16(end.Date - start.Date)));
            }

            // Set newly filled list to be the active routine's activity list
            ar.ActiveActivityList = alist;
            _activeRoutineList.Add(ar);
        }


        // User constructor
        public User(string name)
        {
            _name = name;
            _routineList = new List<Routine>();
            _activeRoutineList = new List<ActiveRoutine>();
        }
        // Properites
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public List<Routine> RoutineList
        {
            get; set;
        }
        public List<ActiveRoutine> ActiveRoutineList
        {
            get; set;
        }
    }
}
