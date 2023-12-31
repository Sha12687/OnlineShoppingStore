﻿using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingStore.Models.Domain
{
    public  class Tbl_Members
    {
      
        public Tbl_Members()
        {
            this.Tbl_ShippingDetails = new HashSet<Tbl_ShippingDetails>();
        }
        [Key]
        public int MemberId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }

      
        public virtual ICollection<Tbl_ShippingDetails> Tbl_ShippingDetails { get; set; }
    }
}