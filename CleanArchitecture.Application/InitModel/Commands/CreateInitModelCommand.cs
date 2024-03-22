using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitecture.Application.InitModel.Commands
{
    public class CreateInitModelCommand : IRequest<CleanArchitecture.Domain.Entities.InitModel>
    {
        public string InitModelName { get; set; }
    }
}
