using ECommerce.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Commons.Adds
{
    public class AddCommandBaseHandler<T> : IRequestHandler<AddCommandBase<T>, ResponseViewModelBase<NoContent>> where T : class
    {
        public AddCommandBaseHandler()
        {
        }

        public virtual async Task<ResponseViewModelBase<NoContent>> Handle(AddCommandBase<T> request, CancellationToken cancellationToken)
        {
            return ResponseViewModelBase<NoContent>.Success(201);
        }
    }
}
