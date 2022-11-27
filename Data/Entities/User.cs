using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User : BaseEntity
    {
        public ICollection<Movie> WatchList { get; set; }
        public ICollection<Movie> WatchedMovies { get; set;}
    }
}
