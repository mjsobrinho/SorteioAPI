namespace SorteioAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using SorteioAPI.Models;
using SorteioAPI.Services.MinhaApi.Services;

[ApiController]
[Route("[controller]")]
public class InfoTelaController : ControllerBase
{
    private readonly InfoTelaService _infoTelaService;

    // Injetar o serviço via construtor
    public InfoTelaController(InfoTelaService infoTelaService)
    {
        _infoTelaService = infoTelaService;
    }

    [HttpGet("{cpf}")]
    public ActionResult<InfoTelaResponse> GetByCpf(string cpf)
    {
        // Utiliza o serviço para obter os dados
        var response = _infoTelaService.GetInfoByCpf(cpf);

        if (response != null)
        {
            return Ok(response);
        }
        else
        {
            return NotFound(new { Message = "CPF não encontrado." });
        }
    }
}
