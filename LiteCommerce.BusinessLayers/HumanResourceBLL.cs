using LiteCommerce.DataLayers;
using LiteCommerce.DomainModels;
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
    public class HumanResourceBLL
    {
        /// <summary>
        /// 
        /// </summary>
        private static IEmployeeDAL EmployeeDB { get; set; }
        /// <summary>
        /// Hàm này phải được gọi để khởi tạo các chức năng tác nghiệp
        /// </summary>
        /// <param name="connectionString"></param>
        public static int Employee_Count(string searchValue)
        {
            return EmployeeDB.Count(searchValue);
        }
        public static Employee Employee_Get(int employeeID)
        {
            return EmployeeDB.Get(employeeID);
        }
        public static void Initialize(string connectionString)
        {
            EmployeeDB = new DataLayers.SqlServer.EmployeeDAL(connectionString);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public static List<Employee> Employee_List(int page, int pageSize, string searchValue)
        {
            if (page < 1)
                page = 1;
            if (pageSize < 1)
                pageSize = 1;
            return EmployeeDB.List(page, pageSize, searchValue);
        }
    }
}
