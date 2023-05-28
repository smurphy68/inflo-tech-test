using System;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;
using MyApp.Models;

namespace MyApp.WinForm
{
    public partial class DeleteUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;
        protected readonly Logger logger;
        protected readonly User user;
        bool userDeleted = false;

        // This form relies upon the 'Main', the DataAccess, and the UserId in order to work
        public DeleteUser(Main main, IServiceFactory serviceFactory, int userId, Logger logger)
        {
            UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;
            this.logger = logger;
            this.user = ServiceFactory.UserService.GetById(UserId);

            InitializeComponent();
        }

        // Load the user for the display
        private void ViewUser_Load(object sender, System.EventArgs e)
        {
            if (user != null && userDeleted == false) // If we have a user then show their details userDeleted stops an error if the target user no longer exists
            {
                lblForename.Text = user.Forename;
                lblSurname.Text = user.Surname;
                lblIsActive.Text = (user.IsActive ? "Yes" : "No");
                lblDOB.Text = user.DateOfBirth.ToShortDateString();
            }
        }

        //A delete button to remove the entry
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete user
                userDeleted = true;
                ServiceFactory.UserService.Delete(user);
                this.Close();

                //Log if Successful
                logger.Log("INFO", "User Deleted.", user);

            } catch (Exception ex)
            {
                logger.Log("ERROR", ex.Message.ToString(), user);
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
