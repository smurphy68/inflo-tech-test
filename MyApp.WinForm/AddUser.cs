using System;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyApp.WinForm
{
    public partial class AddUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;

        // This form relies upon the 'Main', the DataAccess, and the UserId in order to work
        public AddUser(Main main, IServiceFactory serviceFactory /*, int userId*/)
        {
            //UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;

            InitializeComponent();
        }

        /* [START] Section commented out, template taken from View User */

        // Load the user for the display
        //private void ViewUser_Load(object sender, System.EventArgs e)
        //{
        //    // Get the user by the ID
        //    var user = ServiceFactory.UserService.GetById(UserId);

        //    if (user != null) // If we have a user then show their details
        //    {

        //    }
        //}

        /* [END] Section commented out, template taken from View User */

        // A back button to go back to the main list view
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void handleValidationError(object sender, string err)
        {
            MessageBox.Show(err, "Invalid input");
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // declare validation variables
            bool allFieldsComplete, isActiveChecked, dobChecked, forenameChecked, surnameChecked = false;

            // declare variables for creting new user
            DateTime dob;
            bool isActive;
            string forename, surname;

            // add all field values to a list for checking
            List<string> newUserParameters = new List<string> { txtIsActive.Text, txtDateOfBirth.Text, txtForename.Text, txtSurname.Text };

            // check if any fields are empty
            if (newUserParameters.All(i => i != ""))
            {
                allFieldsComplete = true; // first check complete
            }
            else 
            {
                handleValidationError(sender, "Empty Fields");
            }

            // check if active user input == yes or no
            if (txtIsActive.Text.ToLower() == "yes" || txtIsActive.Text.ToLower() == "no")
            {
                isActiveChecked = true;
                isActive = (txtIsActive.Text.ToLower() == "yes") /*? true : false*/;

            }
            else
            {
                handleValidationError(sender, "Active User (Yes or No)");
            }

            // check DOB
            try
            {
                dob = DateTime.Parse(txtDateOfBirth.Text);
                dobChecked = true;
            }
            catch
            {
                handleValidationError(sender, "Date of Birth must be in the format 'DD/MM/YY'");
            }

            // I googled this bit because I thought it would be fun
            // declare regex
            string normalChars = @"[^a-zA-Z0-9]";
            Regex regex = new Regex(normalChars);
            

            // check forename
            if (!regex.IsMatch(txtForename.Text) && txtForename.Text.Length <= 25) { // evaluates to true if special chars are present and the length of the string is less than 50 chars
                forename = txtForename.Text;
            }
            else 
            {
                handleValidationError(sender, "Names cannot contain special characters or be longer than 25 characters");
            }

            // check surname
            if (!regex.IsMatch(txtSurname.Text) && txtSurname.Text.Length <= 25)
            { // evaluates to true if special chars are present and the length of the string is less than 50 chars
                surname = txtForename.Text;
            }
            else
            {
                handleValidationError(sender, "Names cannot contain special characters  or be longer than 25 characters");
            }


        }

        // Override the closing event to show the Main form again
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Main.Show();
        }
    }
}
