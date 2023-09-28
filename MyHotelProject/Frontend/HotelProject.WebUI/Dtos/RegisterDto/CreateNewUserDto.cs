using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad alanını giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanını giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanını giriniz.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail alanını giriniz.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanını giriniz.")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Tekrar şifre alanını giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler aynı olmak zorundadır.")]
        public string ConfirmPassword { get; set; }
    }
}
