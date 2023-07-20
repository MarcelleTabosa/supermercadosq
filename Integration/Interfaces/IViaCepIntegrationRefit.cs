using Refit;
using supermercadosq.Integration.Response;

namespace supermercadosq.Integration.Interfaces
{
    public interface IViaCepIntegrationRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepIntegrationRespose>> GetDataViaCep(string cep);
    }
}
