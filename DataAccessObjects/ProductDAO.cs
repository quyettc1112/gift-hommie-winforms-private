using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        // Singleton Pattern
        private ProductDAO() { }
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
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

        // CRUD
        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>();
            try
            {
                using (var context = new HommieStoreContext())
                {
                    list = context.Products.Include(item => item.Category).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Product Get(int id)
        {
            Product entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Products.Include(item => item.Category).SingleOrDefault<Product>(item => item.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public bool Exist(int id)
        {
            Product entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Products.SingleOrDefault<Product>(item => item.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity != null;
        }

        public void Create(Product entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Id))
                    {
                        throw new Exception("Duplicated entity (id).");
                    }

                    context.Products.Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Product entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Id) == false)
                    {
                        throw new Exception("The entity does not exist: " + entity.Id);
                    }
                    context.Entry<Product>(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + entity.Id);
            }
        }

        public void Save(Product entity)
        {
            try
            {
                if (Instance.Exist(entity.Id))
                    Instance.Update(entity);
                else
                    Instance.Create(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + entity.Id);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    Product entity = Instance.Get(id);
                    if (entity == null)
                    {
                        throw new Exception("Entity is not exist.");
                    }

                    context.Products.Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Product> GetAllWithFilter(string searchId, string searchName, string searchUnitPriceMin, string searchUnitPriceMax, string searchUnitInStockMin, string searchUnitInStockMax, int categoryId)
        {
            string id = (searchId != null) ? searchId : "";
            string name = (searchName != null) ? searchName : "";
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

            List<Product> result = null;

            try
            {
                using (var context = new HommieStoreContext())
                {
                    result = context.Products.Include(item => item.Category)
                            .Where(product => product.Id.ToString().Contains(id)
                            && product.Name.Contains(name)
                            && product.Price >= unitPriceMin
                            && product.Price <= unitPriceMax
                            && product.Quantity >= unitInStockMin
                            && product.Quantity <= unitInStockMax
                            && (categoryId == 0 || product.CategoryId == categoryId)
                            )
                            .ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return result;
        }
    }
}
