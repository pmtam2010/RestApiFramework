using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public interface IAuthLevelService
    {
        Task<AuthenticationLevel> AddAuthenticationLevel(string authName);
        Task<List<AuthenticationLevel>> GetAllLevels();
    }
}
