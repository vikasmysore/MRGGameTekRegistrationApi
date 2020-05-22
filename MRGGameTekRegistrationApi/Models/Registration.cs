using System;
using System.ComponentModel.DataAnnotations;

namespace MRGGameTekRegistrationApi.Models
{
    public abstract class Registration
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
         [Required]
        public string Address { get; set; }
    }
}