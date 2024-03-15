using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitecture.Application.Model.Commands
{
    public class CreateModelCommand : IRequest<CleanArchitecture.Domain.Entities.Model>
    {
        public string ModelName { get; set; }
    }
}
