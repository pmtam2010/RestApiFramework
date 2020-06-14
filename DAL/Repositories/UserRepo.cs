using DAL.DataContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepo : IUserRepo
    {
        /// <summary>
        /// Add a new user
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="email">email</param>
        /// <param name="password">password</param>
        /// <param name="authLevelId">auth level id</param>
        /// <returns></returns>
        public async Task<User> AddUser(string userName, string email, string password, int authLevelId)
        {
            var newUser = new User
            {
                Username = userName,
                Email = email,
                Password = password,
                AuthLevelRefId = authLevelId
            };
            using(var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                await context.Users.AddAsync(newUser);
                await context.SaveChangesAsync();
            }
            return newUser;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetAllUsers()
        {
            List<User> users = new List<User>();
            using(var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                users = await context.Users.ToListAsync();
            }
            return users;
        }

        /// <summary>
        /// // Get users by authentication level id
        /// </summary>
        /// <param name="levelId">level id</param>
        /// <returns>List of users</returns>
        public async Task<List<User>> GetUsersByAuthLevelId(int levelId)
        {
            List<User> users = new List<User>();
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                users = await context.Users.Where(u => u.AuthLevelRefId == levelId).ToListAsync();
            }
            return users;
        }
    }
}
