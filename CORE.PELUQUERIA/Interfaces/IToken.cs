using CORE.PELUQUERIA.Entities;

namespace CORE.PELUQUERIA.Interfaces
{
    public interface IToken
    {
        Task<User> GetLoginByCredential(Security login);
    }
}
