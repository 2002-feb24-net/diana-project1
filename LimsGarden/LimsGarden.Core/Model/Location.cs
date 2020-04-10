using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LimsGarden.Core.Model
{
    ///<summary> 
    /// This is the Location model with data annotations.
    ///</summary>
    public partial class Location
    {
        [Display(Name= "ID")]
        public int LocationId { get; set; }

        [Display(Name= "Branch Name")]
        public string BranchName { get; set; }

        [Display(Name= "Address")]
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }

        [Display(Name= "City")]
        public string City { get; set; }

        [Display(Name= "State")]
        public string StateName { get; set; }

        [Display(Name= "Zip Code")]
        public int? Zipcode { get; set; }

    }
}