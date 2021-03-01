using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class deneme
    {
        [Key]
        public int RandevuId { get; set; }
        public string İstekleriniz { get; set; }
        public string Id { get; set; }
        public UserName user { get; set; }

    }
}
