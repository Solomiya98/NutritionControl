using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NutritionControl.DAL.Concrete.Entities;

namespace NutritionControl.BLL.Concrete.Mappings
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            
            CreateMap<RegistrationViewModel, User>()
                .ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
