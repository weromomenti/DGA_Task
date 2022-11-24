using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUnitOfWork
    {
        IMovieRepository MovieRepository { get; set; }
        IUserRepository UserRepository { get; set; }
        Task SaveChangesAsync();
    }
}
