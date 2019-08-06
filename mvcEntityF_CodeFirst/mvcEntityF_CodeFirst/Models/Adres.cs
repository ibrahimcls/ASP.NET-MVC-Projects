using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcEntityF_CodeFirst.Models
{
    [Table("Adresler")]
    public class Adres
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdresID { get; set; }

        [StringLength(100)]
        public string AdresTanım { get; set; }

        public virtual Kisi adreskisi { get; set; }

    }
}