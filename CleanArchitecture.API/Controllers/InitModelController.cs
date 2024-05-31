using CleanArchitecture.Domain.CustomException;
using CleanArchitecture.Application.InitModel.Queries;
using CleanArchitecture.Application.InitModel.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/InitModel")]
    public class InitModelController : ControllerBase
    {
        private readonly ILogger<InitModelController> _logger;
        private readonly IMediator _mediator;

        public InitModelController(ILogger<InitModelController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] string InitModelId)
        {
            var InitModel = await _mediator.Send(new GetInitModelByIdQuery { InitModelId = InitModelId });

            //throw new InitModelNotFoundException(InitModel.InitModelId, InitModel.InitModelName);

            return Ok(InitModel);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var InitModels = await _mediator.Send(new GetAllInitModelsQuery());
            return Ok(InitModels);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CleanArchitecture.Domain.Entities.InitModel InitModel)
        {
            var InitModels = await _mediator.Send(new CreateInitModelCommand { InitModel = InitModel });
            return Ok(InitModels);
        }
        
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] CleanArchitecture.Domain.Entities.InitModel InitModel)
        {
            var InitModels = await _mediator.Send(new UpdateInitModelCommand { InitModel = InitModel });
            return Ok(InitModels);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] string InitModelId)
        {
            await _mediator.Send(new DeleteInitModelCommand { InitModelId = InitModelId });
            return Ok();
        }
    }
}
