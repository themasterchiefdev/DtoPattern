namespace DtoPattern.WebUi.AutoMapperConfig.Profiles
{
    using AutoMapper;
    using Models;
    using ViewModels;

    public class UserProfile: Profile
    {

        public UserProfile()
        {
            CreateMap<User,UserViewModel>();
        }

    }
}