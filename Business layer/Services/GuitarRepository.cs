using Data_Access_Layer;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business_layer.Services
{
    public class GuitarRepository : IGuitarRepository
    {
        private readonly AppDbContext _appDbContext;

        public GuitarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Guitar> AllGuitars
        {
            get
            {
                return _appDbContext.Guitars.Include(c => c.Category);
            }
        }

        public IEnumerable<Guitar> GuitarsOfTheWeek
        {
            get
            {
                return _appDbContext.Guitars.Include(c => c.Category).Where(p => p.IsGuitarOfTheWeek);
            }
        }

        public Guitar GetGuitarsById(int guitarId)
        {
            return _appDbContext.Guitars.FirstOrDefault(p => p.GuitarId == guitarId);
        }
    }
}


