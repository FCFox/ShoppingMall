using ShoppingMall.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.Domain.Infrastructure
{
    public class UnitOfWork:IDisposable
    {
        private readonly ShoppingMallContext context = null;
        private Repository<Product> productRepository = null;
        private Repository<Category> categoryRepository = null;
        private Repository<Shop> shopRepository = null;
       
        public UnitOfWork()
        {
            context = new ShoppingMallContext();
            context.Database.CreateIfNotExists();
        }

        public Repository<Category> CategoryRpository
        {
            get { return this.categoryRepository ?? new Repository<Category>(context); }
        }
        public Repository<Shop> ShopRpository
        {
            get { return this.shopRepository ?? new Repository<Shop>(context); }
        }
        public Repository<Product> ProductRpository
        {
            get { return this.productRepository ?? new Repository<Product>(context); }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
        public void Dispose()
        {
            
        }
    }
}
