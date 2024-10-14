namespace D_Project.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime? Exparation { get; set; } // TODO: configure this!
    public DateTime CreatedAt { get; set; }

    public Guid MainCategoryId { get; set; }
    public MainCategory MainCategory { get; set; }

    public List<ProductSubCategory> ProductSubCategories { get; set; } = new List<ProductSubCategory>();

    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}