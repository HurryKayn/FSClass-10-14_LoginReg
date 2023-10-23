using System.ComponentModel.DataAnnotations;

namespace App202310_16.ModelsView
{
    public class RegistrazioneAccountVw
    {
        // Nome Utente
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {  get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfermaPassword { get; set; }
    }
}
