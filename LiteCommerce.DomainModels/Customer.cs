using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    /// <summary>
    /// Thông tin về khách hàng
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Please enter a character between 'A' and 'Z'")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Customer ID must be 5 characters")]
        public string CustomerID { get; set; }
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

    }
}
