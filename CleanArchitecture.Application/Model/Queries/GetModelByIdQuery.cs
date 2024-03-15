using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Model.Queries
{
    public class GetModelByIdQuery : IRequest<CleanArchitecture.Domain.Entities.Model>
    {
        public Guid ModelId { get; set; }
    }
}
