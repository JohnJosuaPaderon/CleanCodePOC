using CleanCodePOC.Processes;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanCodePOC.WebApi.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SaveUserResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SaveUserResult>> SaveAsync([FromBody]SaveUser model)
        {
            return Ok(await _mediator.Send(model));
        }
    }
}
