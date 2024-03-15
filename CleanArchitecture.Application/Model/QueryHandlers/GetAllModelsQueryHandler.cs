using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Model.Queries;
using CleanArchitecture.Domain.Interfaces.Repository;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Model.QueryHandlers
{
    public class GetAllModelsQueryHandler : IRequestHandler<GetAllModelsQuery, List<CleanArchitecture.Domain.Entities.Model>>
    {
        private readonly IModelRepository _modelRepository;
        private readonly ILogger<GetAllModelsQueryHandler> _logger;

        public GetAllModelsQueryHandler(IModelRepository ModelRepository, ILogger<GetAllModelsQueryHandler> logger)
        {
            _modelRepository = ModelRepository;
            _logger = logger;
        }

        public async Task<List<Domain.Entities.Model>> Handle(GetAllModelsQuery request, CancellationToken cancellationToken)
        {
            return (List<Domain.Entities.Model>)await _modelRepository.GetAll();
        }
    }
}
