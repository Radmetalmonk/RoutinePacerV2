using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace RoutinePacerv2
{
    [Serializable]
    public class Admin
    {
        private List<User> _userList;

        public Admin()
        {
            // Create a blank user list by default
            _userList = new List<User>();

            // Check if there is a user list, if so replace the default
            // Possible pass in a list via parameter
        }

        // Adds user u to the user list
        public void AddUser(User u)
        {
            _userList.Add(u);
        }

        // Remove user u from the user list
        public void DeleteUser(User u)
        {
            // Delete all of the user's stuff
            //u.Delete();

            // Remove User from the list
            _userList.Remove(u);
        }

        // Return the userlist
        public List<User> UserList
        {
            get { return _userList; }
        }

        // Serialize this Admin Object
        public void Serialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Admin.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }
    }
}
