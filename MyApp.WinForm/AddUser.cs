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

        // declare validation variables
        bool allFieldsComplete, isActiveChecked, dobChecked, forenameChecked, surnameChecked;

        // declare variables for creating new user
        DateTime dob;
        bool isActiveValue;
        string forename, surname;

        // This form relies upon the 'Main' and the DataAccess in order to work
        public AddUser(Main main, IServiceFactory serviceFactory)
        {
            Main = main;
            ServiceFactory = serviceFactory;

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
        private void btnAddUser_Click(object sender, EventArgs e)
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
                //Instantiate Logger
                Logger Logger = new Logger(Main, ServiceFactory);
                
                // Instantiate new empty list
                List<string> dataLog = new List<string>();

                // Instantiate newUser
                User newUser = new User()
                {
                    DateOfBirth = dob,
                    Surname = surname,
                    Forename = forename,
                    IsActive = isActiveValue,
                    DataLog = dataLog
                };

                // Add first log to dataLog
                newUser.DataLog.Add($"[INFO] User: {forename} {surname} was Added.");

                // Add user to database (Ask about ServiceFactories, this took WAY too long to find)
                ServiceFactory.UserService.Create(newUser);
                Logger.WriteFileLog("INFO", $"User: {forename} {surname} was Added.");

                // Show that the new user has been added
                MessageBox.Show(newUser.getString(), "New User Added");
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
