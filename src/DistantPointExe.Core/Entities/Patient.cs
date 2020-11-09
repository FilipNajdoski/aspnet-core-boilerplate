using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DistantPointExe.Entities
{
    public class Patient : Entity, IHasCreationTime
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<AdditionalInfo> AdditionalInfo { get; set; }

        public Patient()
        {
            CreationTime = Clock.Now;
        }

        public Patient(string name, string lastName )
            : this()
        {
            Name = name;
            LastName = lastName;
        }
    }
}
