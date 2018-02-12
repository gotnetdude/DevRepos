﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IdentityServer4.AccessTokenValidation;

namespace Api.Controllers
{
    [Route("[controller]")]
    [Authorize] 
    public class IdentityController : ControllerBase
    {
        public IActionResult Get()
        {
           return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}