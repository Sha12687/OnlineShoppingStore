using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models.Domain
{
    public  class Tbl_MemberRole
    {
        [Key]
        public int MemberRoleID { get; set; }
        public Nullable<int> memberId { get; set; }
        public Nullable<int> RoleId { get; set; }
    }
}