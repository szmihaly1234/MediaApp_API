using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaApp_Models
{
    public enum Category
    {
        Action,Scifi,Adventure,Comedy
    }
    public class Movie : Entity
    {
        public string Title { get; set; }
        [Required]
        [ForeignKey(nameof(Studio))]
        public Studio Studio { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string MovieUrl { get; set; }
        public Category Category { get; set; }

    }
}