using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Model.Queries
{
    public class GetAllModelsQuery : IRequest<List<CleanArchitecture.Domain.Entities.Model>>
    {
    }
}
