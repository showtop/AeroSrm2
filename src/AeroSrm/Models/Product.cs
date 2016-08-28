using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AeroSrm.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public string Colour { get; set; }

        [Display(Name = "Safe Stock Level")]
        public int SafeStockLevel { get; set; }

        [Display(Name = "Current Stock Level")]
        public int CurrentStockLevel { get; set; }

        [Display(Name = "List Price")]
        public decimal ListPrice { get; set; }

        public decimal Size { get; set; }

        [Display(Name = "Size Unit of Measure")]
        public string SizeUnitMeasure { get; set; }

        [Display(Name = "Discontinued Date")]
        public DateTime DiscontinuedDate { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }
    }
}
