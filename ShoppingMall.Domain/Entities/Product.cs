using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.Domain.Entities
{
    public partial class Product
    {
        [Key]
        public int ID { get; set; }
        [StringLength(maximumLength:10,MinimumLength =3,ErrorMessage ="最小长度为3，最大长度为10")]
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:100,MinimumLength =20,ErrorMessage ="最少输入20个字符，最长不超过100个字符")]
        public string Description { get; set; }
        [Required]
        [Range(0.01,999999,ErrorMessage = "最小价格为0.01元，最大价格为999999元")]
        public decimal Price { get; set; }
        
        public int? CategoryID { get; set; } //商品的种类
       
        [Required]
        public int ShopsID { get; set; }//商品所在商铺
        [Required]
        [Range(1,999,ErrorMessage ="最少要有1件商品，并且不超过99件商品")]
        public long Count { get; set; } //商品数量
    }
}
