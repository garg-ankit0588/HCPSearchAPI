using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCPModels;

namespace HCPData
{
    public class AutoMapperConfiguration
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<HCPData, HCPModel>();
                cfg.CreateMap<HCPModel, HCPData>();


            });
        }
    }
}
