using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.InitModel.Queries
{
    public class GetInitModelByIdQuery : IRequest<CleanArchitecture.Domain.Entities.InitModel>
    {
        public string InitModelId { get; set; }
    }
}
