using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.Domain.Entities
{
    /// <summary>
    /// 商铺
    /// </summary>
    public partial class Shop
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Credit { get; set; }//商铺信誉度
    }
    
    public partial class Shop
    {
        public Shop()
        {
            this.Products = new List<Product>();
        }
        public virtual ICollection<Product> Products { get; set; }
    }
}
