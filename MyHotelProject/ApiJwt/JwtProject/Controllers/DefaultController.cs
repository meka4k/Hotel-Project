using JwtProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult NormalToken()
        {
            return Ok(new CreateToken().CreateJwtToken());
        }

        [HttpGet("[action]")]
        public IActionResult AdminToken()
        {
            return Ok(new CreateToken().CreateJwtAdminToken());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Hoşgeldiniz. Normal token başarılı");
        }
        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Hoşgeldiniz. Admin Token başarılı");
        }
    }
}
