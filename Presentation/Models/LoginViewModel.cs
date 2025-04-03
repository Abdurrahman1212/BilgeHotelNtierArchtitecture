using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class LoginViewModel
    {


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Isim alanı boş geçilemez!")]

        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
