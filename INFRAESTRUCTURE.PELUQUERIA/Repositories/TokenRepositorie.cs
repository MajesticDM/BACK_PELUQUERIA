using CORE.PELUQUERIA.Entities;
using CORE.PELUQUERIA.Interfaces;
using INFRAESTRUCTURE.PELUQUERIA.Data;
using Microsoft.EntityFrameworkCore;

namespace INFRAESTRUCTURE.PELUQUERIA.Repositories
{
    public class TokenRepositorie : IToken
    {
        private readonly PELUQUERIAContext _context;
        public TokenRepositorie(PELUQUERIAContext context)
        {
            _context = context;
        }
        public async Task<User> GetLoginByCredential(Security login)
        {
            User users = await _context.Users.FirstOrDefaultAsync(u => u.UserName == login.user && u.Password == login.password);
            return users;
        }
    }
}
