using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcEntityF_CodeFirst.Models
{
    [Table("Kisiler")]
    public class Kisi
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KisilerID { get; set; }

        [StringLength(20),Required]
        public string Ad { get; set; }

        [StringLength(20), Required]
        public string soyad { get; set; }
        [Required]
        public int yas { get; set; }

        public virtual List<Adres> Adres { set; get; }

    }
}