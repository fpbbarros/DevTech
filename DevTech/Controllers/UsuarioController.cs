using System.Text.Json;
using System.Threading.Tasks;
using DevTech.Models;
using DevTech.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevTech.Controllers
{

  [ApiController]
  [Route("Usuario")]
  public class UsuarioController : ControllerBase
  {
    [HttpGet]
    public IActionResult Read([FromServices] IUsuarioRepository repository)
    {
      User usuario = new User();     
      repository.Create(usuario, "");

      return Ok(JsonSerializer.Serialize<User>(usuario));
    }

  }
}