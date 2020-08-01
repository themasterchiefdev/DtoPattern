﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DtoPattern.WebUi.Controllers
{
    using AutoMapper;
    using Models;
    using ViewModels;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[] {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};

        private readonly IMapper _mapper;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast {Date = DateTime.Now.AddDays(index), TemperatureC = rng.Next(-20, 55), Summary = Summaries[rng.Next(Summaries.Length)]}).ToArray();
        // }

        [HttpGet]
        public IEnumerable<WeatherForecastViewModel> Get()
        {
            var rng = new Random();

            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast {Date = DateTime.Now.AddDays(index), TemperatureC = rng.Next(-20, 55), Summary = Summaries[rng.Next(Summaries.Length)]}).ToArray();

            var viewModel = _mapper.Map<WeatherForecastViewModel[]>(result);

            return viewModel;
        }

    }
}