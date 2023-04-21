using Microsoft.AspNetCore.Mvc;

namespace GenshinApplication.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        protected ActionResult CustomResponse(object result = null)
        {
            if (ValidOperation())
            {
                return Ok(new
                {
                    sucess = true,
                    data = result
                });
            }
            return BadRequest(new {
                sucess = false,
                data = GetErrors()
            });

        }
        public bool ValidOperation() {
            return true;
        }
        public string GetErrors()
        {
            return "";
        }
    }
}
