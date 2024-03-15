using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Model.Commands;
using CleanArchitecture.Domain.Interfaces.Repository;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Model.CommandHandlers
{
    public class UpdateModelCommandHandler : IRequestHandler<UpdateModelCommand, CleanArchitecture.Domain.Entities.Model>
    {
        private readonly IModelRepository _modelRepository;
        private readonly ILogger<UpdateModelCommandHandler> _logger;

        public UpdateModelCommandHandler(IModelRepository ModelRepository, ILogger<UpdateModelCommandHandler> logger)
        {
            _modelRepository = ModelRepository;
            _logger = logger;
        }

        public async Task<Domain.Entities.Model> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
        {
            return await _modelRepository.UpdateModel(request.ModelId, request.ModelName);
        }

    }
}
