using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DNN_SupportAnalyst_Homework.Models
{
    public class CreateUserModel
    {
        /*
         This must be passed in. Cannot be null.
         Gets and sets first name
             */
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        /*
         This must be passed in. Cannot be null.
         Gets and sets last name
             */
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        /*
         This must be passed in. Cannot be null.
         Gets and sets username
             */
        [Required]
        [Display(Name = "Username")]
        public string userName { get; set; }

        /*
         This must be passed in. Cannot be null.
         This value must be a valid email address
         Gets and sets email
             */
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }
    }
}