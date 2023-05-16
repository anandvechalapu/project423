using System.Threading.Tasks;
using project423.DTO;

namespace project423.Service
{
    public interface IUserService
    {
        Task LoginAsync(string username, string password);
        Task LogoutAsync();
        Task<UserDTO> RegisterAsync();
        Task UpdateProfileAsync();
    }
}