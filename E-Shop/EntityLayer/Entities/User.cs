using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Boş geçilemez.")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter kullanılabilir.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Boş geçilemez.")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter kullanılabilir.")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Boş geçilemez.")]
        [Display(Name = "E-Posta")]
        [StringLength(50, ErrorMessage = "Max 50 karakter kullanılabilir.")]
        [EmailAddress(ErrorMessage = "E-Mail şeklinde giriniz.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Boş geçilemez.")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "Max 50 karakter kullanılabilir.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Boş geçilemez.")]
        [Display(Name = "Şifre")]
        [StringLength(22, ErrorMessage = "Max 22 karakter kullanılabilir.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Boş geçilemez.")]
        [Display(Name = "Şifre")]
        [StringLength(22, ErrorMessage = "Max 22 karakter kullanılabilir.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }


        [StringLength(12, ErrorMessage = "Max 12 karakter kullanılabilir.")]
        public string Role { get; set; }
    }
}
