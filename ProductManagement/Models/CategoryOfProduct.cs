using System.ComponentModel;

namespace ProductManagement.Models
{
    public class CategoryOfProduct
    {
        [DisplayName("Mã loại sản phẩm")]
        public int CategoryOfProductID { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }
    }
}