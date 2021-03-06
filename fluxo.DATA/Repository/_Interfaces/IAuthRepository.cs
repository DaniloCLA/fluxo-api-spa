using System.Threading.Tasks;
using fluxo.DATA.Models;

namespace fluxo.DATA.Repository
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password, string organizationName);
        Task<User> AddMember(User user, string password, Organization organization);
        Task<User> Login(string email, string password);
        Task<bool> UserExists(string email);        
    }
}