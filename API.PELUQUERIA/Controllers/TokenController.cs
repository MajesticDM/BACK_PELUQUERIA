using CORE.PELUQUERIA.Entities;
using CORE.PELUQUERIA.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.PELUQUERIA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IToken _interface;
        private readonly IConfiguration _configuration;
        public TokenController(IToken Interface, IConfiguration configuration)
        {
            _interface = Interface;
            _configuration = configuration;
        }
        [HttpPost]
        public async Task<IActionResult> Authentication(Security login)
        {
            var users = await _interface.GetLoginByCredential(login);
            if (users != null)
            {
                var token = GenerateToken();
                return Ok(new { token });
            }
            return StatusCode(401);
        }
        private string GenerateToken()
        {
            //Header
            var SymmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));

            var SigningCredentials = new SigningCredentials(SymmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(SigningCredentials);

            //Claims
            var claims = new[]
            {
                new Claim(ClaimTypes.UserData, "noInfo"),
                new Claim(ClaimTypes.Email, "noInfo"),
                new Claim(ClaimTypes.Name, "noInfo"),
            };

            //Payload
            var payload = new JwtPayload
            (
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.Now,
                DateTime.UtcNow.AddMinutes(1)
            );

            //Generate token
            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
