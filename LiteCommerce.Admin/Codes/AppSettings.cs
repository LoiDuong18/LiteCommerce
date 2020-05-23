using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LiteCommerce.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Trả về số trang mặc định
        /// </summary>
        public static int DefaultPageSize
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["DefaultPageSize"]);

            }
        }
    }
}