using System;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;

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

                // resizing shape of column to fit window
                listLogMessages.Columns[0].Width = 700;
                listLogMessages.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

                // if there is any logged information, push it to the listview
                //TODO:
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
