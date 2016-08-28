using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AeroSrm.Models
{
    public class Supplier
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Display(Name = "Supplier Type")]
        public string SupplierType { get; set; }

        [Display(Name = "Billing Currency")]
        public string BillingCurrency { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        public string Skype { get; set; }
        public string Mobile { get; set; }

        [Display(Name = "PayPal")]
        public string Paypal { get; set; }

        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [Display(Name = "Bank Account Number")]
        public string BankAccountNo { get; set; }

        [Display(Name = "Bank Sort Code")]
        public string BankSortCode { get; set; }

        [Display(Name = "Bank BIC")]
        public string BankBIC { get; set; }

        [Display(Name = "IBAN")]
        public string BankIBAN { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("AddressID")]
        public virtual ICollection<Address> Addresses { get; set; }

        [ForeignKey("SupplierProductID")]
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
