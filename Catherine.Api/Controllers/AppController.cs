using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Catherine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        protected IActionResult ApiOk()
        {
            return ApiOk(HttpStatusCode.OK, null);
        }

        protected IActionResult ApiOk(object data)
        {
            return ApiOk(HttpStatusCode.OK, data);
        }

        protected IActionResult ApiOk(HttpStatusCode code, object data)
        {
            return Ok(Catherine.Api.ApiResponse.ApiResponse.Ok(code, data));
        }
    }
}