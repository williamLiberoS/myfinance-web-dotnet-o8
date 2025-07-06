using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_o8.Domain;
using myfinance_web_dotnet_o8.infrastructure;

namespace myfinance_web_dotnet_o8.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly MyFinanceDbContext _banco;

        public TransacaoService(MyFinanceDbContext banco) { _banco = banco; }

    }
}