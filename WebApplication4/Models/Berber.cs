using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Berber
    {
        [Key]
        public int BerberId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string DukkanAdi { get; set; }
        

    }
}
