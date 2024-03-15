using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Model.Commands
{
    public class DeleteModelCommand : IRequest
    {
        public Guid ModelId { get; set; }
    }
}
