using System;
using System.ComponentModel;

namespace ProductManagement.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string NameOfProduct { get; set; }

        [DisplayName("Mã loại sản phẩm")]
        public int CategoryOfProductID { get; set; }

        [DisplayName("Đơn giá")]
        public double Price { get; set; }

        [DisplayName("Ngày khởi tạo")]
        public DateTime CreateDate { get; set; }

        [DisplayName("Ngày thay đổi")]
        public DateTime? ModifyDate { get; set; }
    }
}