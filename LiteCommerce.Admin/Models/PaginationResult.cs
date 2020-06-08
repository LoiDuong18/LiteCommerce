using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiteCommerce.Admin.Models
{
    public class PaginationResult
    {
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
        public string SearchValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
=======
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        public int Page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int RowCount { get; set; }
        /// <summary>
        /// Đếm số trang
        /// </summary>
        public int PageCount
        {
            get
            {
                int pageCount = 1;
                pageCount = RowCount / PageSize;
                if (RowCount % PageSize > 0)
                {
                    pageCount += 1;
                }
                return pageCount;
            }
        }
<<<<<<< HEAD
=======
        public string SearchValue { get; set; }
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
    }
}