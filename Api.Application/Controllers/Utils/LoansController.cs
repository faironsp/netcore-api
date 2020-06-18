using Api.Infra.CrossCutting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;

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

                return new ObjectResult(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", prestacao));
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
