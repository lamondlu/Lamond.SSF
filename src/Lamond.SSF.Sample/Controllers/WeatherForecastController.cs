using Lamond.SSF.Core.Abstract.Domain;
using Lamond.SSF.Sample.Commands;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Lamond.SSF.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICommandBus commandBus;

        public WeatherForecastController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            TestCommand newCommand = new TestCommand
            {
                TestString = "Hello World",
                Operator = "LamondLu"
            };
            commandBus.Send(newCommand);

            Random rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
