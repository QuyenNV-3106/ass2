using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeletePro(int id) => ProductDAO.Instance.Remove(id);

        public ProductObject GetProductByID(int id) => ProductDAO.Instance.GetProductByID(id);

        public IEnumerable<ProductObject> GetProducts() => ProductDAO.Instance.GetProductList();

        public void InsertPro(ProductObject pro) => ProductDAO.Instance.AddNew(pro);

        public IEnumerable<ProductObject> SearchIDAndName(int id, string name) => ProductDAO.Instance.SearchIDAndName(id, name);

        public IEnumerable<ProductObject> SearchPrice(decimal min, decimal max) => ProductDAO.Instance.SearchPrice(min, max);

        public IEnumerable<ProductObject> SearchStock(int min, int max) => ProductDAO.Instance.SearchStock(min, max);

        public void UpdatePro(ProductObject pro) => ProductDAO.Instance.Update(pro);
    }
}
