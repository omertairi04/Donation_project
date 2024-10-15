using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace D_Project.Models
{
    public class EditProductDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]  // Optional: Specify maximum length
        public string Title { get; set; }

        [StringLength(500)]  // Optional: Specify maximum length
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        // Keep Exparation as nullable if not required during updates
        public DateTime? Exparation { get; set; }

        [Required]
        public Guid MainCategoryId { get; set; }

        // Optional: You can keep this if you want to allow changing the subcategories
        public List<Guid> ProductSubCategoryIds { get; set; } = new List<Guid>();
    }
}