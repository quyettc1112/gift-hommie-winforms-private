using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll() => ProductDAO.Instance.GetAll();

        public List<Product> GetAllWithStatus(bool status = true) => ProductDAO.Instance.GetAllWithStatus(status);

        public void Delete(int id) => ProductDAO.Instance.Delete(id);

        public bool Exist(int id) => ProductDAO.Instance.Exist(id);

        public Product Get(int id) => ProductDAO.Instance.Get(id);
        public void Add(Product entity) => ProductDAO.Instance.Save(entity);

        public void Update(Product entity) => ProductDAO.Instance.Update(entity);

        public void Save(Product entity) => ProductDAO.Instance.Save(entity);

        public List<Category> GetAllCategories() => CategoryDAO.Instance.GetAll();

        public Category GetCategoryById(int id) => CategoryDAO.Instance.Get(id);

        public List<Product> GetAllWithFilter(string searchId, string searchName, string searchUnitPriceMin, string searchUnitPriceMax, string searchUnitInStockMin, string searchUnitInStockMax, int categoryId, bool status = true) 
            => GetAllWithFilter(searchId, searchName, searchUnitPriceMin, searchUnitPriceMax, searchUnitInStockMin, searchUnitInStockMax, categoryId, status);
    }
}
