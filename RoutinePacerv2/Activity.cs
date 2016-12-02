using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutinePacerv2
{
    [Serializable]
    public class Activity
    {
        string _name;

        // Name the activity
        public Activity(string name)
        {
            _name = name;
        }

        // Get or Set the name of Activity
        public string Name
        {
            get; set;
        }

    }
}
