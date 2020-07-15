using Api.Application.Controllers.PJBank.Models;
using Api.Domain.Entities;
using LiteDB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Api.Application.Controllers.PJBank
{
    /// <summary>
    /// Classe controller para Usuários
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HooksController : ControllerBase
    {
        private readonly ILogger<HooksController> _logger;
        private readonly IWebHostEnvironment _env;
        private static LiteDatabase _db = new LiteDatabase("Filename=Hooks.db;Mode=Shared");

        public HooksController(ILogger<HooksController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;

            //_db = new LiteDatabase("Filename=PJBank.db;Mode=Shared");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Get a collection (or create, if doesn't exist)
                var col = _db.GetCollection<Hooks>("Hooks");

                // Use LINQ to query documents (filter, sort, transform)
                var results = col.Query().ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex.Message);
            }
        }

        [HttpPut("{instanceName}")]
        public IActionResult Hooks(string instanceName, [FromBody] PjBank content)
        {
            try
            {
                // Get a collection (or create, if doesn't exist)
                var col = _db.GetCollection<Hooks>("Hooks");

                var hooks = new Hooks
                {
                    Id = Guid.NewGuid().ToString(),
                    instanceName = instanceName,
                    PjBankContent = content
                };

                // Insert new customer document (Id will be auto-incremented)
                col.Insert(hooks);

                //Dá um ok na requisição
                PjBankReturn pjBankReturn = new PjBankReturn() { status = 200 };

                return Ok(pjBankReturn);
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                // Get a collection (or create, if doesn't exist)
                var col = _db.GetCollection<Hooks>("Hooks");

                return Ok(col.Delete(id));
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex.Message);
            }
        }
    }
}
