using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    /// <summary>
    /// Thông tin chi tiết về sản phẩm
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int SupplierID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int CategoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string QuantityPerUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public double UnitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Descriptions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhotoPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ProductAttributes> ProductAttributes { get; set; }
    }
    /// <summary>
    /// Thông tin về các thuộc tính bổ sung của sản phẩm
    /// </summary>
    public class ProductAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        public int AttributeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttributeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttributeValues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
