using AutoMapper;
using CORE.PELUQUERIA.DTOs;
using CORE.PELUQUERIA.Entities;
using CORE.PELUQUERIA.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.PELUQUERIA.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialistController : ControllerBase
    {
        private readonly INews _interface;
        private readonly IMapper _mapper;
        public EspecialistController(INews Interface, IMapper mapper)
        {
            _interface = Interface;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> getNews()
        {
            var News = await _interface.GetNews();
            var NewsMap = _mapper.Map<IEnumerable<NewsDTO>>(News);
            return Ok(NewsMap);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getNewsbbyId(int id)
        {
            var News = await _interface.GetNewsbyId(id);
            if (News == null)
            {
                return Ok(News);
            }
            var NewsMap = _mapper.Map<NewsDTO>(News);
            return Ok(NewsMap);
        }
        [HttpPost]
        public async Task<IActionResult> Save(NewsDTO DTOs)
        {
            var News = _mapper.Map<News>(DTOs);
            await _interface.Post(News);
            return Ok(News);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int Id, NewsDTO DTOs)
        {
            var NewsUpd = _mapper.Map<News>(DTOs);
            NewsUpd.NoticeId = Id;
            await _interface.Update(NewsUpd);
            return Ok(NewsUpd);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var News = await _interface.Delete(Id);
            return Ok(News);
        }
    }
}
