using D_Project.Models;

namespace D_Project.Dtos.Product;

public class GetProductDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime? Exparation { get; set; } // TODO: configure this!
    public List<ProductSubCategory> ProductSubCategories { get; set; } = new List<ProductSubCategory>();
    public AppUser AppUser { get; set; }
}