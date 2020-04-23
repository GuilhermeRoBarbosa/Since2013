using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Repositorio;
using Repositorio.Models;
using ServicosAPI.Models;

namespace ServicosAPI.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
                var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Aluno, AlunosModels>();
                cfg.CreateMap<AlunosModels, Aluno>();                

            });
            return config;

        }


    }
}