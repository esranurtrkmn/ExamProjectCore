using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projeSinav.Models
{
    [Table("kullanici")]
    public class Kullanici
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Lütfen adınızı giriniz.")]
        [Display(Name ="Ad")]
        public string ad { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [Display(Name = "Şifre")]
        public string sifre { get; set; }
    }
}

