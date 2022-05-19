using AutoMapper;
using ECommerce.Application.Features.Commands.Commons.Adds;
using ECommerce.Application.Models.Commons;
using ECommerce.Application.Services.Cargos;
using ECommerce.Domain.Entities.Cargos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Cargos.Adds.AddCargo
{
    public class AddCargoCommandHandler : AddCommandBaseHandler<AddCargoCommand>
    {
        private readonly ICargoService _cargoService;
        private readonly IMapper _mapper;
        public AddCargoCommandHandler(IMapper mapper, ICargoService cargoService) : base()
        {
            _mapper = mapper;
            _cargoService = cargoService;
        }

        public async override Task<ResponseViewModelBase<NoContent>> Handle(AddCommandBase<AddCargoCommand> request, CancellationToken cancellationToken)
        {
            var cargoEntity = _mapper.Map<Cargo>(request.Entity);

            await _cargoService.AddAsync(cargoEntity);

            return await base.Handle(request, cancellationToken);
        }
    }
}
