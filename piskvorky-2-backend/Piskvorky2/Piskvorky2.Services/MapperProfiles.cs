using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piskvorky2.Repositories.Models;
using Piskvorky2.Services.Dto;

namespace Piskvorky2.Services
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<PlayerDto, Player>().ReverseMap();
        }
    }
}
