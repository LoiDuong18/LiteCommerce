using LiteCommerce.DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.BusinessLayers
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountBLL
    {
        /// <summary>
        /// 
        /// </summary>
        private static IEmployeeDAL AccountDB { get; set; }
        /// <summary>
        /// Hàm này phải được gọi để khởi tạo các chức năng tác nghiệp
        /// </summary>
        /// <param name="connectionString"></param>
        public static void Initialize(string connectionString)
        {
            AccountDB = new DataLayers.SqlServer.EmployeeDAL(connectionString);
        }
    }
}
