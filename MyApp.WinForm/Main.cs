using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyApp.Models;
using MyApp.Services.Factories.Interfaces;

namespace MyApp.WinForm
{
    public partial class Main : Form
    {
        protected readonly IServiceFactory ServiceFactory;

        // This form relies upon the DataAccess in order to work
        public Main(IServiceFactory serviceFactory) 
        {
            ServiceFactory = serviceFactory;

            InitializeComponent();
        }

        // Set some styles on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            lstUsers.AutoArrange = false;
            lstUsers.MultiSelect = false;
            lstUsers.FullRowSelect = true;

            lstUsers.Columns[0].Width = 50;
            lstUsers.Columns[1].Width = 240;
            lstUsers.Columns[2].Width = 240;
            lstUsers.Columns[3].Width = 70;
        }

        // This overrides the default "Show()" method so we can refresh the ListView
        public new void Show()
        {
            // Get all users
            var users = ServiceFactory.UserService.GetAll();

            // pass the list to the ListView
            LoadListView(users);

            base.Show();
        }

        // Loads the users into the ListView
        private void LoadListView(IEnumerable<User> users)
        {
            lstUsers.Items.Clear();

            lstUsers.Items.AddRange(users.Select(p => new ListViewItem
            (
                new[]
                {
                    p.Id.ToString(),
                    p.Forename,
                    p.Surname,
                    (p.IsActive ? "Yes" : "No")
                }
            )).ToArray());
        }

        

        // Get all users with no filtering
        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            // Get all users from the Data Layer
            var users = ServiceFactory.UserService.GetAll();

            // pass the list to the ListView
            LoadListView(users);
        }

        // Get the users and filter by Active
        private void btnActiveUsers_Click(object sender, EventArgs e)
        {
            // This is the first C# I've ever written, this is terribly exciting...

            // Get all users where the user.IsActive == true;
            var activeUsers = from user in ServiceFactory.UserService.GetAll() where user.IsActive == true select user;
            // Pass list of active users to the ListView;
            LoadListView(activeUsers);
        }

       // Get the users and filter by NonActive
        private void btnNonActiveUsers_Click(object sender, EventArgs e)
        {
            // Get all users where the user.IsActive == false;
            var inactiveUsers = from user in ServiceFactory.UserService.GetAll() where user.IsActive == false select user;
            // Pass list of inactive users to the ListView;
            LoadListView(inactiveUsers);
        }

        // Load a form that allows you to view a selected user
        private void btnView_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count > 0)
            {
                // Get the user id from the selected item in the list view
                var userId = int.Parse(lstUsers.SelectedItems[0].Text);

                // Create new form
                var viewUser = new ViewUser(this, ServiceFactory, userId);

                // Show the new form
                viewUser.Show();

                // Hide this form
                this.Hide();
            }
        }

        // Load a form that allows you to create a new user
        private void btnAdd_Click(object sender, EventArgs e)
        {
                // Create new form
                var addUser = new AddUser(this, ServiceFactory);

                // Show the new form
                addUser.Show();

                // Hide this form
                this.Hide();
        }

        // Load a form that allows you to edit a selected user from the list
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count > 0)
            {    
                // Get the user id from the selected item in the list view
                var userId = int.Parse(lstUsers.SelectedItems[0].Text);

                // Create new form
                var editUser = new EditUser(this, ServiceFactory, userId);

                // Show the new form
                editUser.Show();

                // Hide this form
                this.Hide();
            }
        }

        // Load a form that allows you to delete a selected user from the list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count > 0)
            {
                // Get the user id from the selected item in the list view
                var userId = int.Parse(lstUsers.SelectedItems[0].Text);
                var deleteUser = new DeleteUser(this, ServiceFactory, userId);
                deleteUser.Show();

            }
        }
    }
}
