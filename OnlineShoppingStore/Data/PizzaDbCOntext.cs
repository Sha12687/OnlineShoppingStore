using OnlineShoppingStore.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Data
{
    public class PizzaDbContext :DbContext
    {
        public PizzaDbContext() : base("name=Pizza")
        {
            
        }
   public     DbSet<Tbl_Roles> tbl_ {  get; set; }
   public     DbSet <Tbl_Category> tbl_categories { get; set; }   
  public      DbSet<Tbl_Product> tbl_products { get; set; }
  public      DbSet<Tbl_MemberRole> tbl_member_roles { get; set; }
  public      DbSet<Tbl_ShippingDetails> tbl_shipping_details { get; set; }
  public      DbSet<Tbl_CartStatus> tbl_cart_status { get; set; }
  public      DbSet<Tbl_Cart> tbl_Carts { get; set; } 
    }
}