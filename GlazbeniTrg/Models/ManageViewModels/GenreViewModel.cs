using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlazbeniTrg.Models.ManageViewModels
{
    public class GenreViewModel
    {
        public List<Genre> PrefGenres { get; set; }

        public List<Genre> Genres { get; set; }
        
        public bool[] Values { get; set; }
    }
}
