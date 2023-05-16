using System.Threading.Tasks;
using project423.DataAccess;
using project423.DTO;

namespace project423.Service
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task LoginAsync(string username, string password)
        {
            // login code
        }

        public async Task LogoutAsync()
        {
            // logout code
        }

        public async Task RegisterAsync()
        {
            // register code
        }

        public async Task UpdateProfileAsync()
        {
            // update profile code
        }
    }
}