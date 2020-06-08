using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
<<<<<<< HEAD
=======
    /// <summary>
    /// 
    /// </summary>
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
    public class Account
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int AccountID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime HireDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
<<<<<<< HEAD
        [EmailAddress(ErrorMessage = "Email is valid")]
=======
        [EmailAddress(ErrorMessage ="Email is valid")]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string Email { get; set; }
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
        public string HomePhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhotoPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
    }
}
