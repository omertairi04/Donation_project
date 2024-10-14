namespace D_Project.Models;

public class MainCategory
{
    public Guid Id { get; set; } = Guid.NewGuid(); // Automatically generates a new UUID
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}