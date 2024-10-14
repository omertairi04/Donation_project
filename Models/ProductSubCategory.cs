using D_Project.Models;

public class ProductSubCategory
{
    public Guid ProductId { get; set; } // Foreign key to Product
    public Product Product { get; set; } // Navigation property

    public Guid SubCategoryId { get; set; } // Foreign key to SubCategory
    public SubCategory SubCategory { get; set; } // Navigation property
}