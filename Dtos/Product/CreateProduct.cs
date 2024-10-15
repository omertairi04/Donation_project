namespace D_Project.Dtos
{
    public class CreateProductDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? Exparation { get; set; }
        public Guid MainCategoryId { get; set; }
        public List<Guid> ProductSubCategoryIds { get; set; }
    }
}