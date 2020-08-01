namespace DtoPattern.WebUi.AutoMapperConfig.Profiles
{
    using AutoMapper;
    using Models;
    using ViewModels;

    public class WeatherForecastProfile : Profile
    {

        public WeatherForecastProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastViewModel>();
        }

    }
}