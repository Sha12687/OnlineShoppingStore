using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models.Domain
{
    public  class Tbl_CartStatus
    {
        [Key]
        public int CartStatusId { get; set; }
        public string CartStatus { get; set; }
    }
}