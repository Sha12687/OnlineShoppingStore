using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace OnlineShoppingStore.Models.Domain
{
    public  class Tbl_ShippingDetails
    {
        [Key]
        public int ShippingDetailId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public string PaymentType { get; set; }

        public virtual Tbl_Members Tbl_Members { get; set; }
    }
}