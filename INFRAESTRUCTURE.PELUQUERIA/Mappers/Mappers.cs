using AutoMapper;
using CORE.PELUQUERIA.DTOs;
using CORE.PELUQUERIA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.PELUQUERIA.Mappers
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<News, NewsDTO>();
            CreateMap<NewsDTO, News>();
        }
    }
}
