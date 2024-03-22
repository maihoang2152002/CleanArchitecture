using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.InitModel.Queries
{
    public class GetAllInitModelsQuery : IRequest<List<CleanArchitecture.Domain.Entities.InitModel>>
    {
    }
}
