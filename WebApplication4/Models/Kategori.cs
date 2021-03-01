using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Baslik { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Detay { get; set; }
        public int Fiyat { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Upload File")]
        public string ImageName { get; set; }
        public byte[] Photo { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public ICollection<Randevum> Randevularım { get; set; }
      
    }
}
