using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LimsGarden.Core.Model
{
    ///<summary> 
    /// This is the Customer model with data annotations.
    ///</summary>
    public partial class Customer
    {
        [Display(Name= "ID")]
        [Required]
        public int CustomerId { get; set; }

        [Display(Name= "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name= "Last Name")]
        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Display(Name= "Username")]
        [Required]
        public string Username { get; set; }

        [Display(Name= "Password")]
        [Required]
        public string Password { get; set; }

    }
}