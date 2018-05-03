using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chipotle.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Form Factor")]
        public String FormFactor { get; set; }

        [Required]
        [StringLength(50)]
        public String Rice { get; set; }

        [Required]
        [StringLength(50)]
        public String Beans { get; set; }

        [Required]
        [StringLength(50)]
        public String Protein { get; set; }

        [Required]
        [StringLength(50)]
        public String Lettuce { get; set; }

        [Required]
        [StringLength(50)]
        public String Cheese { get; set; }

        [Required]
        [StringLength(50)]
        public String Quacamole { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Sour Cream")]
        public String SourCream { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Hot Sauce")]
        public String HotSauce { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Mild Sauce")]
        public String MildSauce { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Salsa Verde")]
        public String SalsaVerde { get; set; }
    }
}