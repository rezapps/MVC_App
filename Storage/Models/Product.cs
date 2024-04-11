using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
		[DataType(DataType.Date)]
		public DateTime OrderDate { get; set; }
        public string? Category { get; set; }
        public string? Shelf { get; set; }

		[Range(1, 500)]
		public int Price { get; set; }

		[Range(1, 10000)]
		public int Count { get; set; }
    }
}
