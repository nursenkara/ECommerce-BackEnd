using AutoMapper;
using ECommerce.Application.Features.Queries.Commons.GetAll;
using ECommerce.Application.Models.Commons;
using ECommerce.Domain.Entities.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Queries.Commons
{
    public abstract class GetAllQueryHandler<T> : IRequestHandler<GetAllQuery<T>, ResponseViewModelBase<IReadOnlyList<T>>>
        where T : class
    {
        protected readonly IMapper _mapper;
        protected IReadOnlyList<EntityBase> _baseEntities { get; set; }

        public GetAllQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public virtual async Task<ResponseViewModelBase<IReadOnlyList<T>>> Handle(GetAllQuery<T> request, CancellationToken cancellationToken)
        {
            return ResponseViewModelBase<IReadOnlyList<T>>.Success(_mapper.Map<IReadOnlyList<T>>(_baseEntities), 200);
        }

       
    }
}
