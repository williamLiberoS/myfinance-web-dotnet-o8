using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet_o8.infrastructure;
using myfinance_web_dotnet_o8.Domain;
using myfinance_web_dotnet_o8.Models;
using myfinance_web_dotnet_o8.Services;

namespace myfinance_web_dotnet_o8.Controllers;

[Route("[controller]")]
public class PlanoContaController : Controller
{
    private readonly ILogger<PlanoContaController> _logger;
    private readonly MyFinanceDbContext _banco;
    private readonly IRepository<PlanoConta> _PlanoContaRepository;

    public PlanoContaController(ILogger<PlanoContaController> logger, IRepository<PlanoConta> PlanoContaService)
    {
        _logger = logger;
        _PlanoContaRepository = PlanoContaService;
    }

    [Route("Index")]
    public IActionResult Index()
    {
        ViewBag.Lista = _PlanoContaRepository.ListarRegistros();
        return View();
    }

    public IActionResult Excluir(int id)
    {
        _PlanoContaRepository.Excluir(id);
        return View();
    }

    [HttpPost]
    [HttpGet]
    [Route("Cadastro")]
    [Route("Cadastro/{id}")]
    public IActionResult Cadastro(PlanoContaModel? model, int? id)
    {
        if (id != null && !ModelState.IsValid)
        {
            var registro = _PlanoContaRepository.RetornarRegistro((int)id);
            var planoContaModel = new PlanoContaModel()
            {
                Id = registro.Id,
                Nome = registro.Nome,
                Tipo = registro.Tipo
            };
            return View(planoContaModel);
        }
        else if (model != null && ModelState.IsValid)
        {
            var planoConta = new PlanoConta
            {
                Id = model.Id,
                Nome = model.Nome,
                Tipo = model.Tipo,
            };
            _PlanoContaRepository.Salvar(planoConta);
            return RedirectToAction("Index");
        }
        else
        {
            return View();
        }
    }

    [HttpGet]
    [Route("Excluir/{id}")]
    public IActionResult Editar(int id)
    {
        _PlanoContaRepository.Excluir(id);
        return RedirectToAction("Index");
    }
}
