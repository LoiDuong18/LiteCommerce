using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
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
<<<<<<< HEAD
=======
        [Required]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Please enter a character between 'A' and 'Z'")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Customer ID must be 5 characters")]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string CustomerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string CompanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string ContactName { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string ContactTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fax { get; set; }

    }
}
