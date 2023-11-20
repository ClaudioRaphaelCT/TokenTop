using Microsoft.AspNetCore.Mvc;
using AppTop.Views;
using AppTop.Models;
using AppTop.Utils;

namespace AppTop.Controllers
{
    [ApiController]
    [Route("/topaz/token")]
    public class TokenController : Controller
    {

        [HttpPost(Name = "TokenController")]
        public ActionResult<Token> Index([FromBody] TokenRequest request)
        {

            if (request.user != "Topaz" || request.password != 2023)
            {
                var errorResponse = Messages.MsgValidate("Acesso negado", "Usuario ou senha invalidos");
                return StatusCode(400, errorResponse);
            }
            var okResponse = Messages.MsgValidate("Acesso permitido", "Token 123465");

            return Ok(okResponse);
        }
    }
}
