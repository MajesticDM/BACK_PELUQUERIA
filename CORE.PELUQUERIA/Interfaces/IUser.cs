using CORE.PELUQUERIA.Entities;

namespace CORE.PELUQUERIA.Interfaces
{
    public interface IUser
    {
        Task<IEnumerable<News>> GetNews();
        Task<News> GetNewsbyId(int id);
        Task Post(News news);
        Task<bool> Update(News news);
        Task<bool> Delete(int id);
    }
}
