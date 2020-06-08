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
    /// Thông tin về Category
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public int CategoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        [Required]
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public string CategoryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

    }
}
