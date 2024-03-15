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
    public class GetModelByIdQueryHandler : IRequestHandler<GetModelByIdQuery, CleanArchitecture.Domain.Entities.Model>
    {
        private readonly IModelRepository _modelRepository;
        private readonly ILogger<GetModelByIdQueryHandler> _logger;

        public GetModelByIdQueryHandler(IModelRepository ModelRepository, ILogger<GetModelByIdQueryHandler> logger)
        {
            _modelRepository = ModelRepository;
            _logger = logger;
        }

        public async Task<Domain.Entities.Model> Handle(GetModelByIdQuery request, CancellationToken cancellationToken)
        {
            return await _modelRepository.GetModelById(request.ModelId);
        }
    }
}
