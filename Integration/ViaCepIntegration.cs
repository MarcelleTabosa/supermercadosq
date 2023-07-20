using supermercadosq.Integration.Interfaces;
using supermercadosq.Integration.Response;

namespace supermercadosq.Integration
{
    public class ViaCepIntegration : IViaCepIntegration
    {
        private readonly IViaCepIntegrationRefit _viaCepIntegrationRefit;
        public ViaCepIntegration(IViaCepIntegrationRefit viaCepIntegrationRefit)
        {
            _viaCepIntegrationRefit = viaCepIntegrationRefit;
        }

        public async Task<ViaCepIntegrationRespose> GetDataViaCep(string cep)
        {
            var response = await _viaCepIntegrationRefit.GetDataViaCep(cep);
            if(response != null && response.IsSuccessStatusCode)
            {
                return response.Content;
            }
            return null;
        }
    }
}
