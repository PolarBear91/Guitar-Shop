using Data_Access_Layer.Models;
using System.Collections.Generic;

namespace Shop.UI.ViewModels
{
    public class GuitarsListViewModel
    {
        public IEnumerable<Guitar> Guitars { get; set; }
        public string CurrentCategory { get; set; }
    }
}
