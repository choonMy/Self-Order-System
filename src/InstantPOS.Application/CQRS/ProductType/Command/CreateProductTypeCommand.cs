﻿using System;
using MediatR;

namespace InstantPOS.Application.CQRS.ProductType.Command
{
    public class CreateProductTypeCommand : IRequest<bool>
    {
        public Guid ProductTypeId { get; set; }
        public string ProductTypeKey { get; set; }
        public string ProductTypeName { get; set; }
    }
}
