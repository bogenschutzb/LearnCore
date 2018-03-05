using LearnCore.CommonLibrary.Models;
using System.Collections.Generic;

namespace LearnCore.CommonLibrary.Client.TestRespository
{
    public class UserRepo
    {
        public UserRepo()
        {
            Init();
        }

        public IEnumerable<User> Users { get; set; }

        public void Init()
        {
            Users = new List<User>
            {                 
                new User
                {
                    Id = 1,
                    Name = "Test 1",
                    EmailAddress = "Test1@test.com"
                },
                new User
                {
                    Id = 2,
                    Name = "Test 2",
                    EmailAddress = "Test2@test.com"
                },
                new User
                {
                    Id = 3,
                    Name = "Test 3",
                    EmailAddress = "Test3@test.com"
                }
             };
        }
    }
}
