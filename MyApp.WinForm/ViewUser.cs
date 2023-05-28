using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MyApp.Services.Factories.Interfaces;
using System.Collections.Generic;

namespace MyApp.WinForm
{
    public partial class ViewUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;
        protected readonly Logger logger;

        // This form relies upon the 'Main', the DataAccess, and the UserId in order to work
        public ViewUser(Main main, IServiceFactory serviceFactory, int userId, Logger logger)
        {
            UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;
            this.logger = logger;

            InitializeComponent();

        }

        // Load the user for the display
        private void ViewUser_Load(object sender, System.EventArgs e)
        {
            // Get the user by the ID and parse information if its there
            var user = ServiceFactory.UserService.GetById(UserId);
            if (user != null)
            {
                lblForename.Text = user.Forename;
                lblSurname.Text = user.Surname;
                lblIsActive.Text = (user.IsActive ? "Yes" : "No");
                lblDOB.Text = user.DateOfBirth.ToShortDateString();

                // if there is any logged information, push it to the listview
                if (logger.Logs != null)
                {
                    int i = 0; //list view columns are 0 indexed 
                    foreach (var pair in logger.Logs)
                    {
                        // unpack dictionary values
                        int key = pair.Key;
                        List<string> value = pair.Value;

                        // if the Id matches then push the record to the list view. value[2] is the index of the loggerUserId
                        if (value[2] == user.Id.ToString())
                        {
                            // only load values if the loggedUserId is the target user Id
                            string date = value[0];
                            string severity = value[1];
                            // string loggedUserId = value[2]; // Not used
                            string message = value[3];

                            // add logged messages for the target user to the ListView "listLogMessages"
                            listLogMessages.Items.Add(key.ToString());
                            listLogMessages.Items[i].SubItems.Add(severity);
                            listLogMessages.Items[i].SubItems.Add(date);
                            listLogMessages.Items[i].SubItems.Add(message);

                            //increment i to not overwrite previous rows
                            i++;
                        }

                    }
                }
            }
        }

        // A back button to go back to the main list view
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Override the closing event to show the Main form again
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Main.Show();
        }
    }
}
