using System.ComponentModel.DataAnnotations;

namespace MRGGameTekRegistrationApi.Models
{
    public class RedBetRegistration : Registration
    {
        [Required]
        public string FavouriteFootBallTeam { get; set; }
    }
}