using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int id);
        bool Exist(int id);
        void Add(Product entity);
        void Update(Product entity);
        void Save(Product entity);
        void Delete(int id);

        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
    }
}
