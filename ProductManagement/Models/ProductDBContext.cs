namespace ProductManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext()
            : base("name=ProductDBContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryOfProduct> CategoryOfProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
