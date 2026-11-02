using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Podaj nazwę użytkownika.")]
        [MinLength(8, ErrorMessage = "Nazwa użytkownika musi mieć minimum 8 znaków."]
        [MaxLength(24, ErrorMessage = "Nazwa użytkownika musi mieć maksymalnie 24 znaki."]
        public string Username {get; set; }
        [Required(ErrorMessage = "Podaj adres e-mail.")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail.")]
        public string Email {get; set; }
        [Required(ErrorMessage = "Podaj hasło!")]
        [MinLength(8, ErrorMessage ="Hasło musi mieć minimum 8 znaków."]
        public string Password {get; set; }
        [Required(ErrorMessage = "Potwierdź hasło.")]
        [Compare(nameof(Password), ErrorMessage ="Hasła nie są identyczne.")]
        public string CorfirmPassword {get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Musisz zaakceptowac regulamin.")]
        public bool AcceptTerms { get; set; }
    }
}
