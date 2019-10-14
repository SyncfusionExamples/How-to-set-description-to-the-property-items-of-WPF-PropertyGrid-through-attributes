using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media.Imaging;
using System.Reflection;

namespace PropertyGrid_DescriptionSettings
{
    public class Person
    {
        public Person()
        {
            FirstName = "Carl";
            LastName = "Johnson";
            Age = 30;
            Mobile = 91983467382;
            Email = "carljohnson@gta.com";
            ID = "0005A";
            DOB = new DateTime(1987, 10, 16);
            Designation = "Team Lead";
        }

        [Display(Description = "Email address of the employee")]
        public string Email
        {
            get;

            set;
        }

        [Display(Description = "First Name of the employee")]
        public string FirstName
        {
            get;

            set;
        }

        [Display(Description = "Position of the employee in the organisation")]
        public string Designation
        {
            get;

            set;
        }


        [Display(Description = "Last Name of the employee")]
        public string LastName
        {
            get;

            set;
        }

        [DescriptionAttribute("ID of the employee")]
        public string ID
        {
            get;

            set;
        }


        [DescriptionAttribute("Birth date of the employee")]
        public DateTime DOB
        {
            get;

            set;
        }


        [DescriptionAttribute("Contact Number of the employee")]
        public long Mobile
        {
            get;

            set;
        }

        [DescriptionAttribute("Age of the employee")]
        public int Age
        {
            get;

            set;
        }       
    }
}
