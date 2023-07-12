using BusinessObjects;
using DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
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
        {
            string id = (searchId != null) ? searchId : "";
            string name = (searchName != null) ? searchName.ToLower() : "";
            double unitPriceMin;
            double unitPriceMax;
            int unitInStockMin;
            int unitInStockMax;
            if (searchUnitPriceMin == null || searchUnitPriceMin == "")
            {
                unitPriceMin = 0;
            }
            else
            {
                unitPriceMin = Convert.ToDouble(searchUnitPriceMin);
            }
            if (searchUnitPriceMax == null || searchUnitPriceMax == "")
            {
                unitPriceMax = double.MaxValue;
            }
            else
            {
                unitPriceMax = Convert.ToDouble(searchUnitPriceMax);
            }
            if (searchUnitInStockMin == null || searchUnitInStockMin == "")
            {
                unitInStockMin = 0;
            }
            else
            {
                unitInStockMin = int.Parse(searchUnitInStockMin);
            }
            if (searchUnitInStockMax == null || searchUnitInStockMax == "")
            {
                unitInStockMax = int.MaxValue;
            }
            else
            {
                unitInStockMax = int.Parse(searchUnitInStockMax);
            }

            List<Product> result = GetAll()
                            .Where(product => product.Id.ToString().Contains(id)
                            && product.Name.ToLower().Contains(name)
                            && product.Price >= unitPriceMin
                            && product.Price <= unitPriceMax
                            && product.Quantity >= unitInStockMin
                            && product.Quantity <= unitInStockMax
                            && (categoryId == 0 || product.CategoryId == categoryId)
                            && product.Status == status
                            ).ToList();

            return result;
        }

        public List<Product> GetAllWithFilterWithoutStatus(string searchId, string searchName, string searchUnitPriceMin, string searchUnitPriceMax, string searchUnitInStockMin, string searchUnitInStockMax, int categoryId)
        {
            string id = (searchId != null) ? searchId : "";
            string name = (searchName != null) ? searchName.ToLower() : "";
            double unitPriceMin;
            double unitPriceMax;
            int unitInStockMin;
            int unitInStockMax;
            if (searchUnitPriceMin == null || searchUnitPriceMin == "")
            {
                unitPriceMin = 0;
            }
            else
            {
                unitPriceMin = Convert.ToDouble(searchUnitPriceMin);
            }
            if (searchUnitPriceMax == null || searchUnitPriceMax == "")
            {
                unitPriceMax = double.MaxValue;
            }
            else
            {
                unitPriceMax = Convert.ToDouble(searchUnitPriceMax);
            }
            if (searchUnitInStockMin == null || searchUnitInStockMin == "")
            {
                unitInStockMin = 0;
            }
            else
            {
                unitInStockMin = int.Parse(searchUnitInStockMin);
            }
            if (searchUnitInStockMax == null || searchUnitInStockMax == "")
            {
                unitInStockMax = int.MaxValue;
            }
            else
            {
                unitInStockMax = int.Parse(searchUnitInStockMax);
            }

            List<Product> result = GetAll()
                            .Where(product => product.Id.ToString().Contains(id)
                            && product.Name.ToLower().Contains(name)
                            && product.Price >= unitPriceMin
                            && product.Price <= unitPriceMax
                            && product.Quantity >= unitInStockMin
                            && product.Quantity <= unitInStockMax
                            && (categoryId == 0 || product.CategoryId == categoryId)
                           
                            ).ToList();

            return result;


        }
        
    }
}
