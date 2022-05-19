using AutoMapper;
using ECommerce.Application.Models.Commons;
using ECommerce.Application.Services.Commons;
using ECommerce.Domain.Entities.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Commons.Deletes
{
    public class DeleteCommandBaseHandler<T> : IRequestHandler<DeleteCommandBase<T>, ResponseViewModelBase<NoContent>> where T : EntityBase
    {
        protected readonly IMapper _mapper;

        public DeleteCommandBaseHandler(IMapper mapper,
            IServiceBase<T> service)
        {
            _mapper = mapper;
        }

        public virtual async Task<ResponseViewModelBase<NoContent>> Handle(DeleteCommandBase<T> request, CancellationToken cancellationToken)
        {
            return ResponseViewModelBase<NoContent>.Success(204);
        }
    }
}
