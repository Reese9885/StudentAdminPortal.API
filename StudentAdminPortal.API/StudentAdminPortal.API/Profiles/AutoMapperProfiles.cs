using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain = StudentAdminPortal.API.DomainModels;
using Data = StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Data.Student, Domain.Student>().ReverseMap();

            CreateMap<Data.Gender, Domain.Gender>().ReverseMap();

            CreateMap<Data.Address, Domain.Address>().ReverseMap();
        }
    }
}
