using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MeetingScheduler.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "SVP! entrez votre nom")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "SVP! entrez votre email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "SVP! entrez votre numéro de téléphone")]
        public string? Telephone { get; set; }

        [Required(ErrorMessage = "Veuillez préciser si vous participerez")]
        public bool? Participera { get; set; }
    }
}
