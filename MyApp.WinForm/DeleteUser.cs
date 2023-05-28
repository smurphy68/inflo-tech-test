using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;

namespace MyApp.WinForm
{
    public partial class DeleteUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;

        bool userDeleted = false;


        // This form relies upon the 'Main', the DataAccess, and the UserId in order to work
        public DeleteUser(Main main, IServiceFactory serviceFactory, int userId)
        {
            UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;

            InitializeComponent();
        }

        // Load the user for the display
        private void ViewUser_Load(object sender, System.EventArgs e)
        {
            // Get the user by the ID
            var user = ServiceFactory.UserService.GetById(UserId);

            if (user != null && userDeleted == false) // If we have a user then show their details
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
            //Instantiate Logger
            Logger Logger = new Logger(Main, ServiceFactory);
            try
            {
                userDeleted = true;
                var user = ServiceFactory.UserService.GetById(UserId);
                ServiceFactory.UserService.Delete(user);
                this.Close();

                //Log if Successful
                Logger.WriteFileLog("[INFO]", $"User ID {user.Id}: {user.Forename} {user.Surname} was Deleted.");

            } catch (Exception ex)
            {
                Logger.WriteFileLog("[ERROR]", ex.Message.ToString());
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
