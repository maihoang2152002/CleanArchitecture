using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.InitModel.Queries;
using CleanArchitecture.Domain.Interfaces.Repository;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.InitModel.QueryHandlers
{
    public class GetAllInitModelsQueryHandler : IRequestHandler<GetAllInitModelsQuery, List<CleanArchitecture.Domain.Entities.InitModel>>
    {
        private readonly IInitModelRepository _InitModelRepository;
        private readonly ILogger<GetAllInitModelsQueryHandler> _logger;

        public GetAllInitModelsQueryHandler(IInitModelRepository InitModelRepository, ILogger<GetAllInitModelsQueryHandler> logger)
        {
            _InitModelRepository = InitModelRepository;
            _logger = logger;
        }

        public async Task<List<Domain.Entities.InitModel>> Handle(GetAllInitModelsQuery request, CancellationToken cancellationToken)
        {
            return (List<Domain.Entities.InitModel>)await _InitModelRepository.GetAll();
        }
    }
}
