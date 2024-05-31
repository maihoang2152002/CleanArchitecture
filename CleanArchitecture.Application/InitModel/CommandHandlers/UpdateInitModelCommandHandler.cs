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
    public class UpdateInitModelCommandHandler : IRequestHandler<UpdateInitModelCommand, CleanArchitecture.Domain.Entities.InitModel>
    {
        private readonly IInitModelRepository _InitModelRepository;
        private readonly ILogger<UpdateInitModelCommandHandler> _logger;

        public UpdateInitModelCommandHandler(IInitModelRepository InitModelRepository, ILogger<UpdateInitModelCommandHandler> logger)
        {
            _InitModelRepository = InitModelRepository;
            _logger = logger;
        }

        public async Task<Domain.Entities.InitModel> Handle(UpdateInitModelCommand request, CancellationToken cancellationToken)
        {
            return await _InitModelRepository.UpdateInitModel(request.InitModel);
        }

    }
}
