using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.Domain.Entities
{
    /// <summary>
    /// 商品的种类
    /// </summary>
    public partial class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int ParentID { get; set; }//所属种类的父级
    }
    public partial class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }
        public virtual ICollection<Product> Products { get; set; }
    }
}
