using System.ComponentModel.DataAnnotations;

namespace MRGGameTekRegistrationApi.Models
{
    public class MrGreenRegistration : Registration
    {
        [Required]
        public string PersonalNumber { get; set; }
    }
}