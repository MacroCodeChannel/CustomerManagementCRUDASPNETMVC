using AutoMapper;
using CustomerManagementSystem.Models;
using CustomerManagementSystem.ViewModels;

namespace CustomerManagementSystem.Profiles
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CustomerViewModel,Customer>().ReverseMap();
        }

    }
}
