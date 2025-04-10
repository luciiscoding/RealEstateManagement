using Application.DTOs;
using Application.UseCases.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RealEstateManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PropertiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyDto>>> GetAll()
        {
            var properties = await _mediator.Send(new GetAllPropertiesQuery());
            return Ok(properties);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreatePropertyCommand command)
        {
            var result = await _mediator.Send(command);
            if (!result.IsSuccess)
                return BadRequest(result.Errors);
            return CreatedAtAction(nameof(GetAll), new { id = result.Value.Id }, result.Value);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] UpdatePropertyCommand command)
        {
            if (id != command.Id) return BadRequest("ID mismatch.");
            var result = await _mediator.Send(command);
            if (!result.IsSuccess)
                return BadRequest(result.Errors);
            return NoContent();
        }
    }
}
