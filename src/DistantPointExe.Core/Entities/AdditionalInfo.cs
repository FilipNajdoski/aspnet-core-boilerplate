using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DistantPointExe.Entities
{
    public class AdditionalInfo : Entity
    {
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?[+](1)?[3](1)?[8](1)?[9](1)?[7](1)?[0-9](1)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
