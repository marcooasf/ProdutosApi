using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProdutosApi.Domain;

namespace ProdutosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController(IConfiguration config) : ControllerBase
{
    private static readonly List<Usuario> _usuarios =
    [
    ];

    [HttpPost("Login")]
    {
        var usuario = _usuarios.FirstOrDefault(u => req.login == u.User && req.password == u.Password);
        if (usuario is null) return Unauthorized("Login ou senha inválidos.");

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, usuario.User),
        };
        
    }
}