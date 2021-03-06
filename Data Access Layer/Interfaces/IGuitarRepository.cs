﻿using Data_Access_Layer.Models;
using System.Collections.Generic;

namespace Data_Access_Layer.Interfaces  //Done
{
    public interface IGuitarRepository
    {
        IEnumerable<Guitar> AllGuitars { get; }
        IEnumerable<Guitar> GuitarsOfTheWeek { get; }
        Guitar GetGuitarsById(int guitarId);
    }
}
