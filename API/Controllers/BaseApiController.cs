using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")] //all derived classes will have the attributes inherited 
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
