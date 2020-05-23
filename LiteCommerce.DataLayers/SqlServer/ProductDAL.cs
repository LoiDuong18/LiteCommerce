using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteCommerce.DomainModels;
using System.Data.SqlClient;
using System.Data;

namespace LiteCommerce.DataLayers.SqlServer
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductDAL : IProductDAL
    {
        /// <summary>
        /// 
        /// </summary>
        private string connectionString;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public ProductDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Add(Product data)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productIDs"></param>
        /// <returns></returns>
        public bool Delete(string[] productIDs)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public Product Get(string productID)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public List<Product> List(int page, int pageSize, string searchValue)
        {
            List<Product> data = new List<Product>();
            if (!string.IsNullOrEmpty(searchValue))
                searchValue = "%" + searchValue + "%";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = @"SELECT *
                                        FROM(
                                            SELECT a.ProductID ProductID,a.ProductName ProductName,a.QuantityPerUnit QuantityPerUnit,a.UnitPrice UnitPrice,a.Descriptions Descriptions,a.PhotoPath PhotoPath,b.CompanyName CompanyName,c.CategoryName CategoryName,ROW_NUMBER() OVER(ORDER BY ProductID) AS RowNumber
                                            FROM Products AS a JOIN Suppliers AS b ON b.SupplierID = a.SupplierID
						                                    JOIN Categories AS c ON c.CategoryID = a.CategoryID
                                            WHERE(@searchValue = N'') OR (ProductName like @searchValue)
                                        ) AS t WHERE t.RowNumber BETWEEN (@page - 1) * @pageSize + 1 AND @page * @pageSize
                                        ORDER BY t.RowNumber";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@page", page);
                    cmd.Parameters.AddWithValue("@pageSize", pageSize);
                    cmd.Parameters.AddWithValue("@searchValue", searchValue);
                    using (SqlDataReader dbReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dbReader.Read())
                        {
                            data.Add(new Product()
                            {
                                ProductID = Convert.ToInt32(dbReader["ProductID"]),
                                ProductName = Convert.ToString(dbReader["ProductName"]),
                                CompanyName = Convert.ToString(dbReader["CompanyName"]),
                                CategoryName = Convert.ToString(dbReader["CategoryName"]),
                                QuantityPerUnit = Convert.ToString(dbReader["QuantityPerUnit"]),
                                UnitPrice = Convert.ToString(dbReader["UnitPrice"]),
                                Descriptions = Convert.ToString(dbReader["Descriptions"]),
                                PhotoPath = Convert.ToString(dbReader["PhotoPath"]),
                            });
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Update(Product data)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Đếm số products
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public int Count(string searchValue)
        {
            int dem;
            if (!string.IsNullOrEmpty(searchValue))
                searchValue = "%" + searchValue + "%";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = @"SELECT count(*)
                                        FROM Products
                                        WHERE(@searchValue = N'') OR (ProductName like @searchValue)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@searchValue", searchValue);

                    dem = Convert.ToInt32(cmd.ExecuteScalar());
                }
                connection.Close();
            }
            return dem;
        }
    }
}
