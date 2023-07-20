using supermercadosq.Integration.Response;

namespace supermercadosq.Integration.Interfaces
{
    public interface IViaCepIntegration
    {
        Task<ViaCepIntegrationRespose> GetDataViaCep(string cep);
    }
}
