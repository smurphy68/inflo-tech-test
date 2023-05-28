using System;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyApp.Models;
using System.Reflection.Metadata;

namespace MyApp.WinForm
{
    public partial class EditUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;
        protected readonly Logger logger;
        protected readonly User user;

        // declare validation variables
        bool allFieldsComplete, isActiveChecked, dobChecked, forenameChecked, surnameChecked;

        // declare variables for creating new user
        DateTime dob;
        bool isActiveValue;
        string forename, surname;

        // This form relies upon the 'Main', the DataAccess, and the UserId in order to work
        public EditUser(Main main, IServiceFactory serviceFactory, int userId, Logger logger)
        {
            UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;
            this.logger = logger;
            this.user = ServiceFactory.UserService.GetById(UserId);

            InitializeComponent();

        }

        // A back button to go back to the main list view
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void handleValidationError(object sender, string err)
        {
            MessageBox.Show(err, "Invalid input");
        }

        private void ViewUser_Load(object sender, System.EventArgs e)
        {
            if (user != null) // If we have a user then show their details
            {
                txtForename.Text = user.Forename;
                txtSurname.Text = user.Surname;
                txtIsActive.Text = (user.IsActive ? "Yes" : "No");
                txtDateOfBirth.Text = user.DateOfBirth.ToShortDateString();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                // add all field values to a list for checking
                List<string> newUserParameters = new List<string>
            {
                txtIsActive.Text, txtDateOfBirth.Text, txtForename.Text, txtSurname.Text
            };

                // check if any fields are empty
                if (newUserParameters.All(i => i != ""))
                {
                    allFieldsComplete = true;
                }
                else
                {
                    handleValidationError(sender, "Empty Fields");
                }

                // check if active user input == yes or no
                if (txtIsActive.Text.ToLower() == "yes" || txtIsActive.Text.ToLower() == "no")
                {
                    isActiveChecked = true;
                    isActiveValue = (txtIsActive.Text.ToLower() == "yes") /*? true : false*/;

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
                if (!regex.IsMatch(txtForename.Text) && txtForename.Text.Length <= 25)
                { // evaluates to true if special chars are present and the length of the string is less than 50 chars
                    forename = txtForename.Text;
                    forenameChecked = true;
                }
                else
                {
                    handleValidationError(sender, "Names cannot contain special characters or be longer than 25 characters");
                }

                // check surname
                if (!regex.IsMatch(txtSurname.Text) && txtSurname.Text.Length <= 25)
                { // evaluates to true if special chars are present and the length of the string is less than 50 chars
                    surname = txtSurname.Text;
                    surnameChecked = true;
                }
                else
                {
                    handleValidationError(sender, "Names cannot contain special characters  or be longer than 25 characters");
                }

                if (allFieldsComplete && isActiveChecked && dobChecked && forenameChecked && surnameChecked)
                {

                    // Logging data to User Record, to show on View
                    user.Surname = surname;
                    user.DateOfBirth = dob;
                    user.Forename = forename;
                    user.IsActive = isActiveValue;

                    // Add user to database
                    ServiceFactory.UserService.Update(user);

                    // Show that the new user has been added
                    MessageBox.Show(user.getString(), "User Updated");

                    //Logging if successful
                    logger.Log("INFO", "User was Updated", user);
                }
            }
            catch (Exception ex)
            {
                logger.Log("ERROR", ex.Message.ToString(), user);
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
