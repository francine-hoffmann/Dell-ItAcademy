using Microsoft.AspNetCore.Mvc;

namespace Demowebservice.Controllers;

[ApiController]
[Route("[controller]")]
// apicontroler - vou utilizar os comportamentos padrão para apis do tipo rest
// route permite configurar as regras de controler - variavel pre definida de rotas pois esta com controler entre chaves
//nome desse controlador ../weatherForcast
public class AloMundoController : ControllerBase

private readonly ILogger<WeatherForecastController> _logger;

    public AloMundoController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    [HttpGet]

    public string Get()
    {
        _logger.LogInformation("GET / AloMundo");
        return "Alo Mundo";
    }
    
