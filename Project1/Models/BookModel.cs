using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        [Range(0, 100)]
        public int Quantity { get; set; }
    }
}
