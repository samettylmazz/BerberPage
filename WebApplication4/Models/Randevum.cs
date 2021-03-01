using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Randevum
    {
        [Key]

        public int RandevuId { get; set; }
        public string İstekleriniz { get; set; }
        [Required]
        public DateTime Tarih { get; set; }
        [Required]
        public int KategoriId { get; set; }
        public Kategori Kategorim { get; set; }
      
        [ForeignKey("KullaniciId")]
        public virtual UserName Ad { get; set; }


    }
}
