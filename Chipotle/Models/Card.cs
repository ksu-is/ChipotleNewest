using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chipotle.Models
{
    public class Card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(16)]
        [Display(Name = "Card Number")]
        public String CardNumber { get; set; }

        [Required]
        [Display(Name = "CVC")]
        [StringLength(3)]
        public String CardCVC { get; set; }

        [Required]
        [Display(Name = "Expiration")]
        public String CardExp { get; set; }

    }
}