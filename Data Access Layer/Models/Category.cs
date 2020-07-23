using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string DescriptionOfCategory { get; set; }
        public List<Guitar> Guitars { get; set; }
    }
}
