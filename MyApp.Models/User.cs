using System;
using System.Collections.Generic;

namespace MyApp.Models
{
    public class User : ModelBase
    {
        public string Forename { get; set; }

        public string Surname { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string getString ()
        {
            string _Forename = Forename.ToString();
            string _Surname = Surname.ToString();
            string _isActive = IsActive.ToString();
            string _DateOfBirth = DateOfBirth.ToShortDateString();

            return "Forename: " + _Forename + "\n" + "Surname: " + _Surname + "\n" + "Is Active: " + _isActive + "\n" + "Date of Birth: " + _DateOfBirth;

        }
    }
}