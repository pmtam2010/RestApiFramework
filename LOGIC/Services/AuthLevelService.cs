using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public class AuthLevelService : IAuthLevelService
    {
        private readonly IAuthLevelRepo _levelRepo;

        public AuthLevelService(IAuthLevelRepo levelRepo)
        {
            _levelRepo = levelRepo;
        }

        public async Task<AuthenticationLevel> AddAuthenticationLevel(string authName)
        {
            return await _levelRepo.AddAuthenticationLevel(authName);
        }

        public async Task<List<AuthenticationLevel>> GetAllLevels()
        {
            return await _levelRepo.GetAllLevels();
        }
    }
}
