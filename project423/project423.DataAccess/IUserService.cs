Visual Studio

using project423.DTO;

namespace project423.Service
{
    public interface IUserService
    {
        UserDTO GetUserById(int userId);
        IEnumerable<UserDTO> GetAllUsers();
    }
}