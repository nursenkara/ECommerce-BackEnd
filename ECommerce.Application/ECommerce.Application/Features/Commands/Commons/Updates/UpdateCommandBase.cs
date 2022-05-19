using ECommerce.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Commons.Updates
{
    public class UpdateCommandBase<T> : IRequest<ResponseViewModelBase<NoContent>> where T : class
    {
        public int Id { get; set; }
    }
}
