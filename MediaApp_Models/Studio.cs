using System.ComponentModel.DataAnnotations;

namespace MediaApp_Models
{
    public class Studio : Entity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
        public Studio()
        {
            Movies = new List<Movie>();
        }
    }
}