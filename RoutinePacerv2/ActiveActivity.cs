using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutinePacerv2
{
    [Serializable]
    public class ActiveActivity : Activity
    {
        string _name;
        bool[] _progress;

        // Length represents the number of days to perform activity
        public ActiveActivity(string name, int length) : base (name)
        {
            _progress = new bool[length];
        }
    }
}
