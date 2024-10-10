using MediatR;
using Microsoft.AspNetCore.Mvc;
using Subash.WebAPI.Service.Application.Features.ExamplesFeatures.Query.GetExamples;

namespace Subash.WebAPI.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        [Route("GetExamples")]
        public async Task<ActionResult<GetExampleResponse>> GetExample()
        {
            var response = await _mediator.Send(new GetExampleRequest());
            return Ok(response);
        }
    }
}
