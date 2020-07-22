using Data_Access_Layer.Models;
using System.Collections.Generic;

namespace Shop.UI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Guitar> GuitarsOfTheWeek { get; set; }
    }
}
