# inflo-tech-test

**Project Summary**

This project involved enhancing an existing application that displays a list of users in a list view. 
A video and example output log are available in /Demo

The following steps were completed:

1. **Standard Functionality - Filters Section**
   - Added functionality to filter the list view based on user status.
   - Implemented the "Active Users" button, which displays only users with the 'IsActive' property set to 'True'.
   - Implemented the "Non Active Users" button, which displays only users with the 'IsActive' property set to 'False'.

2. **Standard Functionality - User Model Properties**
   - Expanded the functionality of the 'User' class by adding a new property called 'DateOfBirth'.
   - The 'DateOfBirth' property is of type 'DateTime' and is now utilized and displayed in relevant sections of the application.

3. **Standard Functionality - Actions Section**
   - Implemented the "View" button in the Actions section to display detailed information about a selected user.
   - Enhanced the "View" functionality to include the 'DateOfBirth' property for the displayed user.
   - Created functionality for the "Add", "Edit", and "Delete" buttons in the Actions section:
     - The "Add" button loads a form to create a new user and returns to the user list.
     - The "Edit" button loads a form to edit the details of a selected user from the list.
     - The "Delete" button loads a form to delete a selected user from the list.
   - Ensured proper data validation and displayed appropriate messages to the end user on the UI during all processes.

4. **Advanced Functionality - Data Logging**
   - Extended the application to capture log information for primary user actions (Add, Edit, Delete) and relevant user data.
   - Implemented a log display on the "View" screen, showing all actions performed on the user.

Note: This project was completed using C# in Visual Studio 2022. The application does not have a database and data changes are only persisted in memory while the app is running.
