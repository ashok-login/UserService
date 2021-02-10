using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class UserRepository
    {
        private static List<User> users = new List<User>
        {
            new User { Name = "User1", Email = "user1@example.com", Phone = 1111111111, Topic = "Angular", TimePreference = "morning", Subscription = true },
            new User { Name = "User2", Email = "user2@example.com", Phone = 2222222222, Topic = "Angular", TimePreference = "morning", Subscription = true },
            new User { Name = "User3", Email = "user3@example.com", Phone = 3333333333, Topic = "Angular", TimePreference = "morning", Subscription = true },
            new User { Name = "User4", Email = "user4@example.com", Phone = 4444444444, Topic = "Angular", TimePreference = "morning", Subscription = true }
        };

        public List<User> GetAllUsers()
        {
            return users;
        }

        public bool CreateUser(User user)
        {
            users.Add(user);
            return true;
        }
    }
}
