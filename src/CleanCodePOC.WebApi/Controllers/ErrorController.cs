using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CleanCodePOC.WebApi.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (feature.Error is ValidationException validationException)
            {
                var details = new ProblemDetails
                {
                    Title = "Validation failed"
                };
                details.Extensions.Add("Errors", validationException.Errors);

                return BadRequest(details);
            }
            else
            {
                return Problem();
            }
        }
    }
}
