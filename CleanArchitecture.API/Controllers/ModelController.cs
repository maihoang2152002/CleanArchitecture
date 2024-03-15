using CleanArchitecture.Domain.CustomException;
using CleanArchitecture.Application.Model.Queries;
using CleanArchitecture.Application.Model.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Controllers
{
    [ApiController]
    [Route("api/model")]
    public class ModelController : ControllerBase
    {
        private readonly ILogger<ModelController> _logger;
        private readonly IMediator _mediator;

        public ModelController(ILogger<ModelController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] Guid ModelId)
        {
            var Model = await _mediator.Send(new GetModelByIdQuery { ModelId = ModelId });

            //throw new ModelNotFoundException(Model.ModelId, Model.ModelName);

            return Ok(Model);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var Models = await _mediator.Send(new GetAllModelsQuery());
            return Ok(Models);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CleanArchitecture.Domain.ViewModels.Request.Model Model)
        {
            var Models = await _mediator.Send(new CreateModelCommand { ModelName = Model.ModelName });
            return Ok(Models);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] CleanArchitecture.Domain.ViewModels.Request.Model Model)
        {
            var Models = await _mediator.Send(new UpdateModelCommand { ModelId = Model.Id, ModelName = Model.ModelName });
            return Ok(Models);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] Guid ModelId)
        {
            await _mediator.Send(new DeleteModelCommand { ModelId = ModelId });
            return Ok();
        }
    }
}
