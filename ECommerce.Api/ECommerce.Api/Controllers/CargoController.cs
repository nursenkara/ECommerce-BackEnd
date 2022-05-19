using ECommerce.Application.Features.Commands.Cargos.Adds.AddCargo;
using ECommerce.Application.Models.Cargos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : CustomControllerBase<CargoViewModel, AddCargoCommand>
    {
        public CargoController(IMediator mediator) : base(mediator)
        {
        }
    }
}
