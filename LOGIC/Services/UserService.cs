using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<User> AddUser(string userName, string email, string password, int authLevelId)
        {
            var user = await _userRepo.AddUser(userName, email, password, authLevelId);
            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _userRepo.GetAllUsers();
            return users;
        }

        public async Task<List<User>> GetUsersByAuthLevelId(int levelId)
        {
            var users = await _userRepo.GetUsersByAuthLevelId(levelId);
            return users;
        }
    }
}
