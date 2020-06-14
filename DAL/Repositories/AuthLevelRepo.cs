using DAL.DataContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AuthLevelRepo : IAuthLevelRepo
    {
        public async Task<AuthenticationLevel> AddAuthenticationLevel(string authName)
        {
            var authLevel = new AuthenticationLevel { AuthName = authName };
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {                
                await context.AddAsync(authLevel);
                await context.SaveChangesAsync();
            }
            return authLevel;
        }

        public async Task<List<AuthenticationLevel>> GetAllLevels()
        {
            List<AuthenticationLevel> levels = new List<AuthenticationLevel>();
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                levels = await context.AuthenticationLevels.ToListAsync();
            }
            return levels;
        }
    }
}
