using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    public interface ICategoryDAL
    {
        /// <summary>
        /// Bổ sung thêm một Category
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Category data);
        /// <summary>
        /// Cập nhật một Category
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Category data);
        /// <summary>
        /// Xóa một hoặc nhiều Category(s)
        /// </summary>
        /// <param name="CategoryIDs"></param>
        /// <returns></returns>
        bool Delete(int[] categoryIDs);
        /// <summary>
        /// Lấy thông tin của một Category
        /// </summary>
        /// <param name="CategoryID"></param>
        /// <returns></returns>
        Category Get(int categoryID);
        /// <summary>
        /// Danh sách kết quả tìm kiếm có phân trang
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        List<Category> List(string searchValue);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        int Count(string searchValue);
    }
}
