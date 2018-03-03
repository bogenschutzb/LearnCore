using LearnCore.CommonLibrary.Common;
using LearnCore.CommonLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnCore.CommonLibrary.Users
{
    public interface IUserManager
    {
        Task<User> Get(string id);

        Task<IEnumerable<User>> GetAllUsers();
    }
}
