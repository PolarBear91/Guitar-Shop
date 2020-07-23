
namespace Data_Access_Layer.Models
{
    public class Guitar
    {
        public int GuitarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string DescriptionOfGuitar { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsGuitarOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
