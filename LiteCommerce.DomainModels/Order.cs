using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    /// <summary>
    /// Thông tin về đơn hàng
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public int OrderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RequiredDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShippedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShipperID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Freight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<OrderDetails> OrderDetails { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public int OrderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Discount { get; set; }

    }
}
