using CORE.PELUQUERIA.Entities;
using CORE.PELUQUERIA.Interfaces;
using INFRAESTRUCTURE.PELUQUERIA.Data;
using Microsoft.EntityFrameworkCore;

namespace INFRAESTRUCTURE.PELUQUERIA.Repositories
{
    public class SpecialistRepositorie : INews
    {
        private readonly PELUQUERIAContext _context;
        public SpecialistRepositorie( PELUQUERIAContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<News>> GetNews()
        {
            var News = await _context.News.ToListAsync();
            return News;
        }

        public async Task<News> GetNewsbyId(int id)
        {
            var news = await _context.News.FirstOrDefaultAsync(x => x.NoticeId == id);
            return news;
        }

        public async Task Post(News news)
        {
            _context.Add(news);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> Update(News news)
        {
            var datos = await GetNewsbyId((int)news.NoticeId);
            datos.Notice = news.Notice;
            datos.Photo = news.Photo;
            datos.DateStart = news.DateStart;
            datos.DateEnd = news.DateEnd;

            int filas = await _context.SaveChangesAsync();
            return filas > 0;
        }
        public async Task<bool> Delete(int id)
        {
            var Eliminar = await GetNewsbyId(id);
            _context.News.Remove(Eliminar);

            int filas = await _context.SaveChangesAsync();
            return filas > 0;
        }
    }
}
