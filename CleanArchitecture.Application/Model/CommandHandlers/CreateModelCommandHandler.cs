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
    public class CreateModelCommandHandler : IRequestHandler<CreateModelCommand, CleanArchitecture.Domain.Entities.Model>
    {
        private readonly IModelRepository _modelRepository;
        private readonly ILogger<CreateModelCommandHandler> _logger;

        public CreateModelCommandHandler(IModelRepository ModelRepository, ILogger<CreateModelCommandHandler> logger)
        {
            _modelRepository = ModelRepository;
            _logger = logger;
        }

        public async Task<Domain.Entities.Model> Handle(CreateModelCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Model Model = new Domain.Entities.Model();
            Model.ModelName = request.ModelName;

            return await _modelRepository.AddModel(Model);
        }
    }
}
