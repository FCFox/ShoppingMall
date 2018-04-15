namespace ShoppingMall.Domain.Infrastructure
{
    using ShoppingMall.Domain.Entities;
    using System;
    using System.Collections;
    using System.Data.Entity;
    using System.Linq;

    public class ShoppingMallContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“ShoppingMallContext”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“ShoppingMall.Domain.Infrastructure.ShoppingMallContext”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“ShoppingMallContext”
        //连接字符串。
        public ShoppingMallContext()
            : base()
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //category:一对多
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithRequired() //商品必须有种类
                .HasForeignKey(p => p.CategoryID)
                .WillCascadeOnDelete(false);
            //shop:一对多
            modelBuilder.Entity<Shop>()
                .HasMany(s => s.Products)
                .WithRequired() //商品依赖商铺存在
                .HasForeignKey(p => p.ShopsID);

            base.OnModelCreating(modelBuilder);
        }
    }
}