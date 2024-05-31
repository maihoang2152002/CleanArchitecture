using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.InitModel.Commands
{
    public class UpdateInitModelCommand : IRequest<CleanArchitecture.Domain.Entities.InitModel>
    {
        public CleanArchitecture.Domain.Entities.InitModel InitModel { get; set; }
    }
}
