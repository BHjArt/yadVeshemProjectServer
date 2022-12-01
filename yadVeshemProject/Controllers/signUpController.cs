using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Authorization;
using Entities;

namespace yadVeshemProject.Controllers
{
    [Route("api/[controller]")]

    public class signUpController : Controller
    {
        IsignUpBl _IsignUpBl;
        public signUpController(IsignUpBl IsignUpBl)
        {
            _IsignUpBl = IsignUpBl;

        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<User>> Get()
        {
            List<User> user = await _IsignUpBl.getRegisters();
            return Ok(user);
        }


    }
}
