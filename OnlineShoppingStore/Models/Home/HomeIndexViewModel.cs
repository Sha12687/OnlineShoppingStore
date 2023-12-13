
using OnlineShoppingStore.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using OnlineShoppingStore.Data;
using OnlineShoppingStore.Models.Domain;

namespace OnlineShoppingStore.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        PizzaDbContext context = new PizzaDbContext();
        
     
        public IPagedList<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search, int pageSize, int? page)
        {
            
            var query = context.tbl_products.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.ProductName.Contains(search) || p.Description.Contains(search));
            }

            // Execute the query and paginate the results using ToPagedList
            IPagedList<Tbl_Product> data = query.OrderBy(p => p.ProductId).ToPagedList(page ?? 1, pageSize);

            // Create and return the view model
            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }


    }
}