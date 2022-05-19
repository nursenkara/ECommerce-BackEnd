﻿using ECommerce.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Commands.Commons.Adds
{
    public class AddCommandBase<T> : IRequest<ResponseViewModelBase<NoContent>> where T : class
    {
        public T Entity { get; set; }
    }
}
