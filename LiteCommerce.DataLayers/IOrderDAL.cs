using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOrderDAL
    {
        /// <summary>
        /// Bổ sung thêm một Order
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Order data);
        /// <summary>
        /// Cập nhật một Order
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Order data);
        /// <summary>
        /// Xóa một hoặc nhiều Order(s)
        /// </summary>
        /// <param name="OrderIDs"></param>
        /// <returns></returns>
        bool Delete(string[] orderIDs);
        /// <summary>
        /// Lấy thông tin của một Order
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        Order Get(string orderID);
        /// <summary>
        /// Danh sách kết quả tìm kiếm có phân trang
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        List<Order> List(int page, int pageSize, string searchValue);
    }
}
