using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Ad Alanını Giriniz")]
        [Display(Name = "Öğrenci Ad")]
        public string Ad { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Geçersiz Mail")]
        [Display(Name = "Mail Adres")]
        public string Email { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
    }
}
