using ECommerce.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Queries.Commons.GetAll
{
    public class GetAllQuery<T> : IRequest<ResponseViewModelBase<IReadOnlyList<T>>> where T : class
    {
    }
}
