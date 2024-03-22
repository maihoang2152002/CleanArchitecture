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
    public class GetInitModelByIdQueryHandler : IRequestHandler<GetInitModelByIdQuery, CleanArchitecture.Domain.Entities.InitModel>
    {
        private readonly IInitModelRepository _InitModelRepository;
        private readonly ILogger<GetInitModelByIdQueryHandler> _logger;

        public GetInitModelByIdQueryHandler(IInitModelRepository InitModelRepository, ILogger<GetInitModelByIdQueryHandler> logger)
        {
            _InitModelRepository = InitModelRepository;
            _logger = logger;
        }

        public async Task<Domain.Entities.InitModel> Handle(GetInitModelByIdQuery request, CancellationToken cancellationToken)
        {
            return await _InitModelRepository.GetInitModelById(request.InitModelId);
        }
    }
}
