using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    public interface IShipperDAL
    {
        /// <summary>
        /// Bổ sung thêm một Shipper
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Shipper data);
        /// <summary>
        /// Cập nhật một Shipper
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Shipper data);
        /// <summary>
        /// Xóa một hoặc nhiều Shipper(s)
        /// </summary>
        /// <param name="ShipperIDs"></param>
        /// <returns></returns>
        bool Delete(int[] shipperIDs);
        /// <summary>
        /// Lấy thông tin của một Shipper
        /// </summary>
        /// <param name="ShipperID"></param>
        /// <returns></returns>
        Shipper Get(int shipperID);
        /// <summary>
        /// Danh sách kết quả tìm kiếm có phân trang
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        List<Shipper> List(string searchValue);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        int Count(string searchValue);
    }
}
