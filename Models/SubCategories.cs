using D_Project.Models;

public class SubCategory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }

    public Guid MainCategoryId { get; set; } // Foreign key to MainCategory
}