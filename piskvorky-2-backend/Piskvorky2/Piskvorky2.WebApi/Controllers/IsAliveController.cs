using Microsoft.AspNetCore.Mvc;

namespace Piskvorky2.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IsAliveController : ControllerBase
    {
        public IsAliveController()
        {
        }

        [HttpGet]
        public bool Get()
        {
            return true;
        }
    }
}