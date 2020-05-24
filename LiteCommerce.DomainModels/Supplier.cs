using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    /// <summary>
    /// Thông tin về nhà cung cấp
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// 
        /// </summary>
        public int SupplierID { get; set; }
        /// <summary>
        /// 
        /// </summary>        
        public string CompanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ContactTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HomePage { get; set; }
    }
}
