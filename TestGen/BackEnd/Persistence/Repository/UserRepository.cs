using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly GeneratorDbContext _context;

        public UserRepository(GeneratorDbContext context)
        {
            _context = context;
        }

        public IQueryable<ApplicationUser> GetAll()
        {
            return _context.Users;
        }
        
        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
           var result = _context.Users.Find(user.Id).Id.ToString();
           
           return Task.FromResult(result);
        }

        public async Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var result = _context.Users.Find(user.Id).UserName;
           
            return result.ToUpper();
        }

        public async Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = userName.ToUpper();
        }

        public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var normalized = _context.Users.Find(user.Id).NormalizedUserName;

            return Task.FromResult(normalized);
        }

        public async Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName.ToUpper();
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {

            try
            {
                await _context.AddAsync(user, cancellationToken);

                await _context.SaveChangesAsync(cancellationToken);

                return IdentityResult.Success;
            }
            catch
            {
                return IdentityResult.Failed();
            }

        }

        public async Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            try
            {
                var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

                trackedUser.Email = user.Email;
                trackedUser.PasswordHash = user.PasswordHash;
                trackedUser.UserName = user.UserName;

                _context.Entry(trackedUser).State = EntityState.Modified;

                await _context.SaveChangesAsync(cancellationToken);

                return IdentityResult.Success;
            }
            catch
            {
                return IdentityResult.Failed();
            }
        }

        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var result = new IdentityResult();

            var trackedUser = _context.Users.FindAsync(user.Id,cancellationToken);

            _context.Remove(trackedUser);

            _context.SaveChangesAsync(cancellationToken);

            return Task.FromResult(result);
        }

        public async Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            int id = Int32.Parse(userId);

            var user = await _context.Users.FindAsync(id, cancellationToken);

            return user;
        }

        public async Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var userName = normalizedUserName;

            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName, cancellationToken);

            return user;
        }

        public void Dispose()
        {
        }

        public async Task SetEmailAsync(ApplicationUser user, string email, CancellationToken cancellationToken)
        {
            var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

            trackedUser.Email = email;

            _context.Entry(trackedUser).State = EntityState.Modified;

            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<string> GetEmailAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

            return trackedUser.Email;
        }

        public async Task<bool> GetEmailConfirmedAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

            return trackedUser.EmailConfirmed;
        }

        public async Task SetEmailConfirmedAsync(ApplicationUser user, bool confirmed, CancellationToken cancellationToken)
        {
            var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

            trackedUser.EmailConfirmed = confirmed;

            _context.Entry(trackedUser).State = EntityState.Modified;

            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<ApplicationUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email.ToUpper() == normalizedEmail);

            return user;
        }

        public async Task<string> GetNormalizedEmailAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

            return trackedUser.Email.ToUpper();
        }

        public async Task SetNormalizedEmailAsync(ApplicationUser user, string normalizedEmail, CancellationToken cancellationToken)
        {
            user.NormalizedEmail = normalizedEmail.ToUpper();

        }

        public async Task SetPasswordHashAsync(ApplicationUser user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
        }

        public async Task<string> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

            return trackedUser.PasswordHash;
        }

        public async Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var trackedUser = await _context.Users.FindAsync(user.Id, cancellationToken);

            return !string.IsNullOrEmpty(trackedUser.PasswordHash);    
        }
    }
}