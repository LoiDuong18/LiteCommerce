using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string CompanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string ContactName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string ContactTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
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
