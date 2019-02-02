using System.Threading.Tasks;
using Api.Models;

namespace Api.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(string userName, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}