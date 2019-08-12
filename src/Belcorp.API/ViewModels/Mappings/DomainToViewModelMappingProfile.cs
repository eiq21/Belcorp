using AutoMapper;
using Belcorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belcorp.API.ViewModels.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>()
               .ForMember(vm => vm.Id,
                   map => map.MapFrom(s => s.CategoryId))
               .ForMember(vm => vm.Name, map =>
                   map.MapFrom(s => s.CategoryName))
               .ForMember(vm=> vm.Description,map=> map.MapFrom(s=>s.CategoryDescription));

        }
    }
}
