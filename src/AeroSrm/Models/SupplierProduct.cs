using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AeroSrm.Models
{
    public class SupplierProduct
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Supplier's Product ID")]
        public int SupplierProductID { get; set; }

        public decimal Weight { get; set; }

        [Display(Name = "Weight Unit")]
        public string WeightUnitMeasure { get; set; }

        [Display(Name = "Days to Manufacture")]
        public int DaysToProduce { get; set; }

        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Minimum Order Quantity")]
        public int MinOrderQty { get; set; }

        [Display(Name = "Maximum Order Quantity")]
        public int MaxOrderQty { get; set; }

        [ForeignKey("Supplier")]
        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        [ForeignKey("Product")]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
