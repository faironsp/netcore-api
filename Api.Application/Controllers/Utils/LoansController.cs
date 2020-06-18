using Api.Domain.Entities;
using Api.Service.Validators;
using Api.Infra.CrossCutting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Api.Application.Controllers.Utils
{
    /// <summary>
    /// Classe controller para Usuários
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class LoansController : ControllerBase
    {
        private readonly ILogger<LoansController> _logger;

        public LoansController(ILogger<LoansController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] double pv, [FromQuery] double i, [FromQuery] int n)
        {
            try
            {
                var prestacao = LoanCalculator.CalculaPrestacao(pv, (i / 100), n);

                return new ObjectResult(prestacao);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
