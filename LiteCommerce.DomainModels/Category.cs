using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    /// <summary>
    /// Thông tin về Category
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 
        /// </summary>
        
        public int CategoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string CategoryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

    }
}
