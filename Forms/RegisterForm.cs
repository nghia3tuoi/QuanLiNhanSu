using System.ComponentModel.DataAnnotations;

namespace QLNS.Forms
{
    public class RegisterForm
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }


        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "PasswordAgain is required")]
        public string? PasswordAgain { get; set; }
    }
}
