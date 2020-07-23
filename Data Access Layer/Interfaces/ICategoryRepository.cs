using Data_Access_Layer.Models;
using System.Collections.Generic;


namespace Data_Access_Layer.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
