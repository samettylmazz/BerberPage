using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
   
    public class UserName:IdentityUser
    {
       

        public string Ad { get; set; }
       
        public string soyad { get; set; }
        public ICollection<deneme> Randevularım { get; set; }
        public ICollection<Randevum> Randevuk{ get; set; }
    }
}
