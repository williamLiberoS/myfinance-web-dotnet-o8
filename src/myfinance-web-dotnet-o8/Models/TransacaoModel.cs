using Microsoft.AspNetCore.Mvc.Rendering;
using myfinance_web_dotnet_o8.Services;
using myfinance_web_dotnet_o8.Domain;

namespace myfinance_web_dotnet_o8.Models
{
    public class TransacaoModel
    {
        public TransacaoModel(IRepository<PlanoConta> planoContaService)
        {
            var listaPlanoContas = planoContaService.ListarRegistros();
            PlanoContas = new SelectList(listaPlanoContas, "Id", "Nome");
            Data = DateTime.Now;
        }

        public int? Id { get; set; }
        public string? Historico { get; set; }
        public string? Tipo { get; set; }
        public DateTime Data { get; set; }
        public int PlanoContaId { get; set; }
        public IEnumerable<SelectListItem>? PlanoContas { get; set; }
        public decimal Valor { get; set; }
    }
}