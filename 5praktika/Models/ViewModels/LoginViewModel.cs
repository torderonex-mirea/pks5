using System.ComponentModel.DataAnnotations;

namespace _5praktika.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите никнейм")]
        public string? Username { get; set; }
		[Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите пароль")]
		public string? Password { get; set; }
    }
}
