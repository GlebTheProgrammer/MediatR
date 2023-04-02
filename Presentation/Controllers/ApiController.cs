using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api")]
    public abstract class ApiController : ControllerBase
    {
        public ApiController(ISender sender) => Sender = sender;

        protected ISender Sender { get; }

        //protected IActionResult BadRequest(Error error) => BadRequest(new ApiErrorResponse(new[] { error }));

        //protected new IActionResult Ok(object value) => base.Ok(value);

        //protected new IActionResult NotFound() => base.NotFound();
    }
}
