using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IAuthLevelRepo
    {
        Task<AuthenticationLevel> AddAuthenticationLevel(string authName);
        Task<List<AuthenticationLevel>> GetAllLevels();
    }
}
