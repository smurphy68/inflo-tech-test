using System;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyApp.Models;

namespace MyApp.WinForm
{
    public partial class AddUser : Form
    {
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;
        protected readonly Logger logger;
        protected readonly User newUser;

        // declare validation variables
        bool allFieldsComplete, isActiveChecked, dobChecked, forenameChecked, surnameChecked;

        // declare variables for creating new user
        DateTime dob;
        bool isActiveValue;
        string forename, surname;

        // This form relies upon the 'Main' and the DataAccess in order to work
        public AddUser(Main main, IServiceFactory serviceFactory, Logger logger)
        {
            Main = main;
            ServiceFactory = serviceFactory;
            InitializeComponent();
            this.logger = logger;
            newUser = new User();
        }

        // A back button to go back to the main list view
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // A custom method to tell the users the error with the input fields
        private void handleValidationError(object sender, string err)
        {
            MessageBox.Show(err, "Invalid input.");
        }

        // Method to conduct data validation, add user to the DataContext and trigger logging; if the input is valid
        private void btnAddUser_Click(object sender, EventArgs e)
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
                    handleValidationError(sender, "Empty Fields.");
                }

                // check if active user input == yes or no
                if (txtIsActive.Text.ToLower() == "yes" || txtIsActive.Text.ToLower() == "no")
                {
                    isActiveChecked = true;
                    isActiveValue = (txtIsActive.Text.ToLower() == "yes") /*? true : false*/;
                }
                else
                {
                    handleValidationError(sender, "Active User (Yes or No).");
                }

                // check DOB can be parsed into DateTime
                try
                { 
                    dob = DateTime.Parse(txtDateOfBirth.Text); // if this causes an error the dobChecked parameter should stay false.
                    dobChecked = true;
                }
                catch
                {
                    handleValidationError(sender, "Date of Birth must be in the format 'DD/MM/YY'.");
                }

                // Data validation for Forename and Surname of new User
                // declare regex
                string normalChars = @"[^a-zA-Z0-9]";
                Regex regex = new Regex(normalChars);

                // check forename
                if (!regex.IsMatch(txtForename.Text) && txtForename.Text.Length <= 25) // evaluates to true if special chars are present and the length of the string is less than 50 chars
                { 
                    forename = txtForename.Text;
                    forenameChecked = true;
                }
                else
                {
                    handleValidationError(sender, "Names cannot contain special characters or be longer than 25 characters.");
                }

                // check surname
                if (!regex.IsMatch(txtSurname.Text) && txtSurname.Text.Length <= 25) // evaluates to true if special chars are present and the length of the string is less than 50 chars
                { 
                    surname = txtSurname.Text;
                    surnameChecked = true;
                }
                else
                {
                    handleValidationError(sender, "Names cannot contain special characters  or be longer than 25 characters.");
                }

                // if all of the above control flows have passed, all of the following bools should allow the creation of a new user.
                if (allFieldsComplete && isActiveChecked && dobChecked && forenameChecked && surnameChecked)
                {
                    newUser.DateOfBirth = dob;
                    newUser.Surname = surname;
                    newUser.Forename = forename;
                    newUser.IsActive = isActiveValue;

                    // Check that the user opened in this window cannot be added twice
                    if (ServiceFactory.UserService.GetById(newUser.Id) == null)
                    {
                        ServiceFactory.UserService.Create(newUser);

                        // Show that the new user has been added
                        MessageBox.Show(newUser.getString(), "New User Added.");

                        // Log user creation
                        logger.Log("INFO", "New User has been Added.", newUser);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Log("ERROR", ex.Message.ToString(), newUser);
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
