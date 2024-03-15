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
    public class DeleteModelCommandHandler : IRequestHandler<DeleteModelCommand>
    {
        private readonly IModelRepository _modelRepository;
        private readonly ILogger<DeleteModelCommandHandler> _logger;

        public DeleteModelCommandHandler(IModelRepository ModelRepository, ILogger<DeleteModelCommandHandler> logger)
        {
            _modelRepository = ModelRepository;
            _logger = logger;
        }

        public async Task Handle(DeleteModelCommand request, CancellationToken cancellationToken)
        {
            await _modelRepository.DeleteModel(request.ModelId);
        }
    }
}
