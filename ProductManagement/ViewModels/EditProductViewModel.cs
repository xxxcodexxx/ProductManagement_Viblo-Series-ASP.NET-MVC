using ProductManagement.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ProductManagement.ViewModels
{
    public class EditProductViewModel
    {
        public EditProductViewModel(int productID, string nameOfProduct, int categoryOfProductID)
        {
            ProductID = productID;
            NameOfProduct = nameOfProduct;
            CategoryOfProductID = categoryOfProductID;
            GetCategories();
        }
        public EditProductViewModel()
        {
            GetCategories();
        }

        public int ProductID { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string NameOfProduct { get; set; }

        public int CategoryOfProductID { get; set; }

        public IEnumerable<CategoryOfProduct> CategoryOfProducts { get; set; }

        public void GetCategories()
        {
            using (ProductDBContext db = new ProductDBContext())
            {
                CategoryOfProducts = db.CategoryOfProducts.ToList().AsEnumerable();
            }
        }
    }
}