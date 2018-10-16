using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCPService.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //Data to Model
                cfg.CreateMap<HCPData.HCPData, HCPModels.HCPModel>().ForMember(c => c.HCPId, o => o.MapFrom(src => src.HCPId)).
                ForMember(c => c.FirstName, o => o.MapFrom(src => src.FirstName)).ForMember(c => c.LastName, o => o.MapFrom(src => src.LastName)).
                ForMember(c => c.SpecialityName, o => o.MapFrom(src => src.SpecialityMaster.SpecialityName));
               

                //Model to Data
                cfg.CreateMap<HCPModels.HCPModel, HCPData.HCPData>();

                cfg.CreateMap<HCPData.HCPData, IEnumerable<HCPModels.HCPModel>>();
                cfg.CreateMap< IEnumerable < HCPModels.HCPModel >, HCPData.HCPData >();
            });
        }
    }
}
