using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data_Access_Layer.MockRepository
{
    public class MockGuitarRepository : IGuitarRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Guitar> AllGuitars =>
            new List<Guitar>
            {
                new Guitar {
                    GuitarId = 1,
                    Brand = "Gibson",
                    Model = "Les Paul Studio",
                    DescriptionOfGuitar="Lorem Ipsum",
                    Price=15.95M,
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    IsGuitarOfTheWeek=false,
                    InStock=true}
            };

        public IEnumerable<Guitar> GuitarsOfTheWeek { get; }

        public Guitar GetGuitarsById(int guitarId)
        {
            return AllGuitars.FirstOrDefault(p => p.GuitarId == guitarId);
        }
    }
}
