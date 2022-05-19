using AutoMapper;
using ECommerce.Application.Features.Commands.Cargos.Adds.AddCargo;
using ECommerce.Application.Models.Cargos;
using ECommerce.Domain.Entities.Cargos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region Authentications

            //CreateMap<User, SignUpUserCommand>().ReverseMap();
            //CreateMap<User, UserViewModel>().ReverseMap();

            #endregion

            #region Cargos

            CreateMap<Cargo, CargoViewModel>().ReverseMap();
            CreateMap<Cargo, AddCargoCommand>().ReverseMap();

            #endregion
        }
    }
}
