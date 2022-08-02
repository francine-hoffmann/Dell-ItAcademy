using Microsoft.AspNetCore.Mvc;

namespace Demowebservice.Controllers;

[ApiController]
[Route("[controller]")]
// apicontroler - vou utilizar os comportamentos padrão para apis do tipo rest
// route permite configurar as regras de controler - variavel pre definida de rotas pois esta com controler entre chaves
//nome desse controlador ../weatherForcast
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
//array de strings , resumo do tempo
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
// injeção de dependencias (logger)
    [HttpGet(Name = "GetWeatherForecast")]
    //metodo de ação - requisição do tipo get na URL  get../WeatherForcast - que retorna uma coleção enumerada WeatherForcast
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
        // vamos criar uma enumeração de range 1 até 5 valores. para cada um deles ele excutou um select, entra um index de 1 até 5, para cada index executa a expressão lambda abaixo  
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            //gera um numero aleatorio entre -20 ate 55
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //gera uma previsão do tamanho do array
        })
        .ToArray();
        //executa 
    }
    
}
