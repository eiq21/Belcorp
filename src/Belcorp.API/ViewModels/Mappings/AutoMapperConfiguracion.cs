using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belcorp.API.ViewModels.Mappings
{
    public class AutoMapperConfiguracion
    {
        public static void Configure() {
            Mapper.Initialize(x => {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
