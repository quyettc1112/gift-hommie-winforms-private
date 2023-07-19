using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        // Singleton Pattern
        private CategoryDAO() { }
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }



        // CRUD
        public List<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            try
            {
                using (var context = new HommieStoreContext())
                {
                    list = context.Categories.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Category Get(int id)
        {
            Category entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Categories.SingleOrDefault<Category>(item => item.Id == id);
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
            Category entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Categories.SingleOrDefault<Category>(item => item.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity != null;
        }

        public void Create(Category entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Id))
                    {
                        throw new Exception("Duplicated entity (id).");
                    }

                    context.Categories.Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Category entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Id) == false)
                    {
                        throw new Exception("The entity does not exist: " + entity.Id);
                    }
                    context.Entry<Category>(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + entity.Id);
            }
        }

        public void Save(Category entity)
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
                    Category entity = Instance.Get(id);
                    if (entity == null)
                    {
                        throw new Exception("Entity is not exist.");
                    }

                    context.Categories.Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
