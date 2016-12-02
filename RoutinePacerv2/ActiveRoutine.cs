using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutinePacerv1
{
    public class ActiveRoutine
    {
        string _name;
        List<ActiveActivity> _activeActivityList;

        DateTime _start;
        DateTime _end;
        DateTime _rollover;

        // Constructor sets name and initializes list
        public ActiveRoutine(string name, DateTime start, DateTime end, DateTime rollover)
        {
            _name = name;
            _start = start;
            _end = end;
            _rollover = rollover;
            _activeActivityList = new List<ActiveActivity>();
        }

        // Properties
        public string Name
        { get; set; }
        public List<ActiveActivity> ActiveActivityList
        { get; set; }
        public DateTime Start
        { get; set; }
        public DateTime End
        { get; set; }
        public DateTime Rollover
        { get; set; }

    }
}
