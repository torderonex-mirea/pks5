using System.ComponentModel.DataAnnotations;

namespace _5praktika.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите никнейм")]
        public string? Username { get; set; }
		[Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите пароль")]
		public string? Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите имя")]
        public string? FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите фамилию")]
        public string? LastName { get; set; }
    }
}
