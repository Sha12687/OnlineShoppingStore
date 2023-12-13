using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models.Domain
{
    public  class Tbl_Roles { 
       [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}