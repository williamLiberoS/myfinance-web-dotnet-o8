using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_o8.Domain;
using myfinance_web_dotnet_o8.infrastructure;

namespace myfinance_web_dotnet_o8.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private readonly MyFinanceDbContext _banco;

        public PlanoContaService(MyFinanceDbContext banco) { _banco = banco; }

        public List<PlanoConta> RetornarTransacaoMaisCaraDoAno(int Ano)
        { 
            throw new NotImplementedException();
        }
    }
}