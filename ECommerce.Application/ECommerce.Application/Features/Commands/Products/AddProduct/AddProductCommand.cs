using ECommerce.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Products.AddProduct
{
    public class AddProductCommand: IRequest<ResponseViewModelBase<NoContent>>
    {
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
