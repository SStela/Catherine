using System.Net;
using Catherine.Api.Models.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace Catherine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        protected IActionResult ApiOk(object data)
        {
            return ApiOk(HttpStatusCode.OK, data);
        }

        protected IActionResult ApiOk(HttpStatusCode code, object data)
        {
            return Ok(ApiResponse.Ok(code, data));
        }
    }
}