using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace RoutinePacerv1
{
    public partial class F_AdminPanel : Form
    {
        // Master admin object
        private Admin _admin;

        // Panel constructor
        // Loads admin object if exists and updates listbox
        public F_AdminPanel()
        {
            InitializeComponent();

            // Create an admin object to maintain users
            _admin = new Admin();

            // Check if admin exists, if so, deserialize it
            if (File.Exists("Admin.bin"))
            {
                _admin = LoadAdmin();
            }

            // Set and display list contents
            UpdateListBox();

            // Start with no selections
            LB_Admin.ClearSelected();
        }

        // Create an add a user to the admin list
        public void AddUser()
        {
            // Prompt user for a name
            string tempName = GetUserName();
            // If the string returned is blank, don't add the user
            if (tempName != "")
            {
                User u = new User(tempName);
                _admin.AddUser(u);
            }
        }
        
        // Select a user from the list
        // Close this form
        // Display the active routine form
        // Deserialize User
        public void SelectUser()
        {
            // do stuff
        }

        // Prompts user for a user name
        // Returns a string, either the name or the empty string
        public string GetUserName()
        {
            using (NewUserForm newUserForm = new NewUserForm())
            { 
                // If the user selects OK, return the string
                if (newUserForm.ShowDialog() == DialogResult.OK)
                {
                    return newUserForm.GetUserName();
                }
                else
                {
                    // Otherwise, return the empty string
                    return "";
                }
            }
        }

        // Save the state
        public void SaveAdmin()
        {
            _admin.Serialize();
        }

        // Deserialize Admin object
        public Admin LoadAdmin()
        {
            Admin temp;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Admin.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            temp = (Admin)formatter.Deserialize(stream);
            stream.Close();
            return temp;
        }

        // Select the user
        private void B_SelectUser_Click(object sender, EventArgs e)
        {
            SelectUser();
        }

        // Create a user, updates listbox, and saves admin
        private void B_NewUser_Click(object sender, EventArgs e)
        {
            AddUser();
            UpdateListBox();
            SaveAdmin();
        }

        // Update listbox
        public void UpdateListBox()
        {
            LB_Admin.DataSource = null;
            LB_Admin.DataSource = _admin.UserList;
            LB_Admin.DisplayMember = "Name";
        }
    }
}
