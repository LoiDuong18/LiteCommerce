using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiteCommerce.Admin.Models
{
    public class ProductPaginationResult:PaginationResult
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Product> Data;
        /// <summary>
        /// 
        /// </summary>
        public string CategoryID;
        /// <summary>
        /// 
        /// </summary>
        public string SupplierID;
    }
}