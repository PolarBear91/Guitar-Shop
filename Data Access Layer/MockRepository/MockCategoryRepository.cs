using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System.Collections.Generic;

namespace Data_Access_Layer.MockRepository
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Electric Guitars", DescriptionOfCategory="Best solution for rock!"},
                new Category{CategoryId=2, CategoryName="Acoustic Guitars", DescriptionOfCategory="For dreamers"},
                new Category{CategoryId=3, CategoryName="Bass Guitars", DescriptionOfCategory="You need good bass? Click here!"}
            };
    }
}
