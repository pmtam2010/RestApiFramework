using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IUserRepo
    {
        //Add a new user
        Task<User> AddUser(string userName, string email, string password, int authLevelId);

        // Get users by authentication level id
        Task<List<User>> GetUsersByAuthLevelId(int levelId);

        //Get all users
        Task<List<User>> GetAllUsers();
    }
}
