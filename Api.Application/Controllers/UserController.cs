using Api.Domain.Entities;
using Api.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Aplicattion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private BaseService<User> service = new BaseService<User>();
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<User> userList = new List<User>();

                for (int i = 0; i < 5; i++)
                {
                    var user = new User();
                    user.Name = $"Fabio: {i}";
                    user.BirthDate = DateTime.Now;
                    user.Cpf = "34568868882";

                    userList.Add(user);
                }

                return new ObjectResult(userList);
                //return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
