using System.Text.Json;
using System.Threading.Tasks;
using DevTech.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevTech.Controllers
{

  [ApiController]
  [Route("Usuario")]
  public class UsuarioController : ControllerBase
  {
    [HttpGet]
    public IActionResult Read()
    {
      Usuario usuario = new Usuario();     

      return Ok(JsonSerializer.Serialize<Usuario>(usuario));
    }

  }
}