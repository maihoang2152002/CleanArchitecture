using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.InitModel.Commands;
using CleanArchitecture.Domain.Interfaces.Repository;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.InitModel.CommandHandlers
{
    public class DeleteInitModelCommandHandler : IRequestHandler<DeleteInitModelCommand>
    {
        private readonly IInitModelRepository _InitModelRepository;
        private readonly ILogger<DeleteInitModelCommandHandler> _logger;

        public DeleteInitModelCommandHandler(IInitModelRepository InitModelRepository, ILogger<DeleteInitModelCommandHandler> logger)
        {
            _InitModelRepository = InitModelRepository;
            _logger = logger;
        }

        public async Task Handle(DeleteInitModelCommand request, CancellationToken cancellationToken)
        {
            await _InitModelRepository.DeleteInitModel(request.InitModelId);
        }
    }
}
