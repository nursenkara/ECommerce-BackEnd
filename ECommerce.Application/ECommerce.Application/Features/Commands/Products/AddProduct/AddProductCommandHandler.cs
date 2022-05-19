using AutoMapper;
using ECommerce.Application.Features.Commands.Commons.Adds;
using ECommerce.Application.Models.Commons;
using ECommerce.Application.Services.ECommerce;
using ECommerce.Domain.Entities.ECommerce;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Products.AddProduct
{
    public class AddProductCommandHandler : AddCommandBaseHandler<AddProductCommand>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public AddProductCommandHandler(IMapper mapper, IProductService productService) : base()
        {
            _mapper = mapper;
            _productService = productService;
        }

        public async override Task<ResponseViewModelBase<NoContent>> Handle(AddCommandBase<AddProductCommand> request, CancellationToken cancellationToken)
        {
            var productEntity = _mapper.Map<Product>(request.Entity);

            await _productService.AddAsync(productEntity);

            return await base.Handle(request, cancellationToken);
        }
    }
}
