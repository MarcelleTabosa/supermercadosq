using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermercadosq.Integration.Interfaces;
using supermercadosq.Integration.Response;

namespace supermercadosq.Controllers.Integration
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegration _viaCepIntegration;

        public CepController(IViaCepIntegration viaCepIntegration)
        {
            _viaCepIntegration = viaCepIntegration;
        }

        [HttpGet]
        public async Task<ActionResult<ViaCepIntegrationRespose>> AddressData(string cep)
        {
            var response = await _viaCepIntegration.GetDataViaCep(cep);
            if (response == null)
            {
                return BadRequest("CEP not found");
            }
            return Ok(response);
        }
    }
}
