using ProductManagement.Models;
using System.ComponentModel;

namespace ProductManagement.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(int productID, string nameOfProduct, int categoryOfProductID)
        {
            ProductID = productID;
            NameOfProduct = nameOfProduct;
            CategoryOfProductID = categoryOfProductID;
            GetCategory();
        }
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string NameOfProduct { get; set; }

        public int CategoryOfProductID { get; set; }

        [DisplayName("Tên loại sản phẩm")]
        public string CategoryName { get; set; }

        public void GetCategory()
        {
            if (CategoryOfProductID > 0)
            {
                using (ProductDBContext db = new ProductDBContext())
                {
                    this.CategoryName = db.CategoryOfProducts.Find(this.CategoryOfProductID) != null ?
                        db.CategoryOfProducts.Find(this.CategoryOfProductID).Description : string.Empty;
                }
            }
        }
    }
}