using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using Microsoft.AspNetCore.Identity;

namespace Core.Managers
{
    public class UserStore : IUserStore<ApplicationUser>,
        IUserPasswordStore<ApplicationUser>, 
        IUserEmailStore<ApplicationUser>, 
        IUserSecurityStampStore<ApplicationUser>,
        IQueryableUserStore<ApplicationUser>
    {

        private readonly IUserRepository _userRepository;


        public UserStore(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return user.Id.ToString();
        }

        public async Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return user.UserName;
        }

        public async Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            user.UserName = userName;
        }

        public async Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            return user.UserName.ToUpper();
        }

        public async Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            user.NormalizedUserName = normalizedName.ToUpper();
        }

        public Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return _userRepository.CreateAsync(user, cancellationToken);
        }

        public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return _userRepository.UpdateAsync(user, cancellationToken);
        }

        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return _userRepository.DeleteAsync(user, cancellationToken);
        }

        public Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            return _userRepository.FindByIdAsync(userId, cancellationToken);
        }

        public Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return _userRepository.FindByNameAsync(normalizedUserName, cancellationToken);
        }
        
        public void Dispose()
        {
            
        }

        public async Task SetEmailAsync(ApplicationUser user, string email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            user.Email = email;
        }

        public async Task<string> GetEmailAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            return user.Email;
        }

        public async Task<bool> GetEmailConfirmedAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
            {
                throw new ArgumentNullException();
            }
            
            return user.EmailConfirmed;
        }

        public async Task SetEmailConfirmedAsync(ApplicationUser user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            
            user.EmailConfirmed = confirmed;
        }

        public Task<ApplicationUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            return _userRepository.FindByEmailAsync(normalizedEmail, cancellationToken);
        }

        public async Task<string> GetNormalizedEmailAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return user.Email.ToUpper();
        }

        public Task SetNormalizedEmailAsync(ApplicationUser user, string normalizedEmail, CancellationToken cancellationToken)
        {
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            
            return _userRepository.SetNormalizedEmailAsync(user, normalizedEmail, cancellationToken);
        }

        public async Task SetPasswordHashAsync(ApplicationUser user, string passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            
            user.PasswordHash = passwordHash;
        }

        public async Task<string> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            return user.PasswordHash;
        }

        public async Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            
            return !string.IsNullOrEmpty(user.PasswordHash);
        }

        public async Task SetSecurityStampAsync(ApplicationUser user, string stamp, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            
            user.SecurityStamp = stamp;
        }

        public async Task<string> GetSecurityStampAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            return user.SecurityStamp;
        }

        public IQueryable<ApplicationUser> Users
        {
            get { return _userRepository.GetAll(); }
        }
    }
}