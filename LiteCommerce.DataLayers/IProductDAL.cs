﻿using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    public interface IProductDAL
    {
        /// <summary>
        /// Bổ sung thêm một Product
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Product data);
        /// <summary>
        /// Cập nhật một Product
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Product data);
        /// <summary>
        /// Xóa một hoặc nhiều Product(s)
        /// </summary>
        /// <param name="ProductIDs"></param>
        /// <returns></returns>
        bool Delete(string[] productIDs);
        /// <summary>
        /// Lấy thông tin của một Product
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        Product Get(string productID);
        /// <summary>
        /// Danh sách kết quả tìm kiếm có phân trang
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        List<Product> List(int page, int pageSize, string searchValue);
    }
}
