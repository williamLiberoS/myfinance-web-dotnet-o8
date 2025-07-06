using myfinance_web_dotnet_o8.Domain;

namespace myfinance_web_dotnet_o8.Services
{
    public interface IPlanoContaService
    {
        List<PlanoConta> RetornarTransacaoMaisCaraDoAno(int Ano);
    }
}