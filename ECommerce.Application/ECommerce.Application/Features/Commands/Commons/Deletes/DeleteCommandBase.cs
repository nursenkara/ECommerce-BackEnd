using ECommerce.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Commons.Deletes
{
    public class DeleteCommandBase<T> : IRequest<ResponseViewModelBase<NoContent>> where T : class
    {
        public T Entity { get; set; }
    }
}
