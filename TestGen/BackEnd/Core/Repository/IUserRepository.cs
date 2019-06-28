using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Core.Repository
{
    public interface IUserRepository : IUserEmailStore<ApplicationUser>, IUserPasswordStore<ApplicationUser>
    {
        IQueryable<ApplicationUser> GetAll();
    }
}    