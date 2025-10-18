using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazor.Components.Models
{
    public class RegisterFormModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Required]
        [PasswordPropertyText]
        public string RepeatPassword { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
