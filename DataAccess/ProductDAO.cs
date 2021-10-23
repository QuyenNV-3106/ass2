using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<ProductObject> GetProductList()
        {
            IDataReader dataReader = null;
            string sqlSelect = "Select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitsInStock From Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(sqlSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.StackTrace);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CloseConnection();
            }
            return products;
        }
        public ProductObject GetProductByID(int proID)
        {
            ProductObject pro = null;
            IDataReader dataReader = null;
            string sql = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitsInStock " +
                         "From Product " +
                         "Where ProductId = @ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 5, proID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(sql, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    pro = new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CloseConnection();
            }
            return pro;
        }

        public void AddNew(ProductObject pro)
        {
            try
            {
                ProductObject product = GetProductByID(pro.ProductID);
                if (product == null)
                {
                    string sql = "Insert Product Values(@ProductId, @CategoryId, @ProductName, @Weight, @UnitPrice, @UnitInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 5, pro.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 5, pro.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, pro.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, pro.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 50, pro.UnitPrice, DbType.Currency));
                    parameters.Add(dataProvider.CreateParameter("@UnitInStock", 10, pro.UnitsInStock, DbType.Int32));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(ProductObject pro)
        {
            try
            {
                ProductObject product = GetProductByID(pro.ProductID);
                if (product != null)
                {
                    string sql = "Update Product set CategoryId = @CategoryId, ProductName = @ProductName, " +
                        "Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock Where ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 5, pro.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 5, pro.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, pro.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, pro.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 50, pro.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 10, pro.UnitsInStock, DbType.Int32));
                    dataProvider.Update(sql, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Product is not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int proID)
        {
            try
            {
                ProductObject pro = GetProductByID(proID);
                if (pro != null)
                {
                    string sql = "Delete Product Where ProductId = @ProductId";
                    var param = dataProvider.CreateParameter("@ProductId", 5, proID, DbType.Int32);
                    dataProvider.Delete(sql, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The Product is not already exist.");

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public IEnumerable<ProductObject> SearchPrice(decimal min, decimal max)
        {
            IEnumerable<ProductObject> list = from pro in GetProductList()
                                              where pro.UnitPrice >= min && pro.UnitPrice <= max
                                              select pro;
            return list;
        }

        public IEnumerable<ProductObject> SearchStock(int min, int max)
        {
            IEnumerable<ProductObject> list = from pro in GetProductList()
                                              where pro.UnitsInStock >= min && pro.UnitsInStock <= max
                                              select pro;
            return list;
        }

        public IEnumerable<ProductObject> SearchIDAndName(int id, string name)
        {
            IEnumerable<ProductObject> list = from pro in GetProductList()
                                              where pro.ProductID == id || pro.ProductName.ToLower().Trim().Contains(name.ToLower().Trim())
                                              select pro;
            return list;
        }
    }
}
