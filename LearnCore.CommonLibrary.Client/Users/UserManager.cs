using LearnCore.CommonLibrary.Client.TestRespository;
using LearnCore.CommonLibrary.Models;
using LearnCore.CommonLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.CommonLibrary.Client.Users
{
    public class UserManager : IUserManager
    {
        #region Private Properties
        private readonly ITestRepositoryManager _repositoryManager;
        #endregion

        #region Constructon
        public UserManager(ITestRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        #endregion

        #region Methods
        public Task<User> Get(string id)
        {            
            var find = _repositoryManager.UserRepo.Users.SingleOrDefault(x => x.Id.ToString().Equals(id, StringComparison.CurrentCultureIgnoreCase));

            return Task.FromResult(find);
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            return Task.FromResult<IEnumerable<User>>(_repositoryManager.UserRepo.Users);
        }        
        #endregion

    }
}
