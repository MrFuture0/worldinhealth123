using System.Collections.Generic;
using a.data.Abstract;
using a.entity;

namespace a.data.Concrete.EfCore
{
    public class EfCoreCategoryRepistory : ICategoryRepistorycs
    {
        private shopcontext db = new shopcontext();
        public void Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetPopularCategories()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}