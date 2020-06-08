using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    /// <summary>
    /// Thông tin về shipper
    /// </summary>
    public class Shipper
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int ShipperID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string CompanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Phone { get; set; }
    }
}
