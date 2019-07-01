using Core.Models;

namespace Api.ViewModels
{
    public class TokenResponse
    {
        public string Token { get; set; }
        
        public UserResponse User { get; set; }
    }
}