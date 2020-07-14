﻿using Api.Application.Controllers.PJBank.Models;
using Api.Domain.Entities;
using Api.Service.Services;
using LiteDB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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

        public HooksController(ILogger<HooksController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var path = Path.Combine(_env.ContentRootPath, "Data", "Hooks.db");

            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(path))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Hooks>("Hooks");

                // Use LINQ to query documents (filter, sort, transform)
                var results = col.Query().ToList();

                return Ok(results);
            }
        }

        [HttpPut("{instanceName}")]
        public IActionResult Hooks(string instanceName, [FromBody] PjBank content)
        {
            var path = Path.Combine(_env.ContentRootPath, "Data", "Hooks.db");

            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(path))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Hooks>("Hooks");

                var hooks = new Hooks
                {
                    Id = Guid.NewGuid().ToString(),
                    instanceName = instanceName,
                    PjBankContent = content
                };

                // Insert new customer document (Id will be auto-incremented)
                col.Insert(hooks);
            }

            //Dá um ok na requisição
            PjBankReturn pjBankReturn = new PjBankReturn() { status = 200 };

            return Ok(pjBankReturn);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var path = Path.Combine(_env.ContentRootPath, "Data", "Hooks.db");

            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(path))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Hooks>("Hooks");

                return Ok(col.Delete(id));
            }
        }
    }
}