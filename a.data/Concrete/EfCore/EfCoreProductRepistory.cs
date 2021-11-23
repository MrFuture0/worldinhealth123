using System.Collections.Generic;
using a.data.Abstract;
using a.entity;

namespace a.data.Concrete.EfCore
{
    public class EfCoreProductRepistory : IProductRepistory
    {

        private shopcontext db = new shopcontext();

        void IRepistory<Product>.Create(Product entity)
        {
           db.Products.Add(entity);
           db.SaveChanges();
        }

        void IRepistory<Product>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        List<Product> IRepistory<Product>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Product IRepistory<Product>.GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        List<Product> IProductRepistory.GetPopularProduct()
        {
            throw new System.NotImplementedException();
        }

        void IRepistory<Product>.Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}