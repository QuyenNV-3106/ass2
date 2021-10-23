using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetProducts();
        ProductObject GetProductByID(int id);
        void InsertPro(ProductObject pro);
        void DeletePro(int id);
        void UpdatePro(ProductObject pro);
        IEnumerable<ProductObject> SearchPrice(decimal min, decimal max);
        IEnumerable<ProductObject> SearchStock(int min, int max);
        IEnumerable<ProductObject> SearchIDAndName(int id, string name);
    }
}
