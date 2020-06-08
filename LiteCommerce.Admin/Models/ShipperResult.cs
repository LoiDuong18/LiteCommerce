using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiteCommerce.Admin.Models
{
    public class ShipperResult
    {
        /// <summary>
        /// 
        /// </summary>
        public int RowCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Shipper> Data;
    }
}