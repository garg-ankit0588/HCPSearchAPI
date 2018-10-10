using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCPModels;
using HCPRepositories.Interfaces;
using HCPData;

namespace HCPRepositories.Implementations
{
    public class HCPRepository : Repository<HCPData.HCPData>, IHCPRepository
    {
        public HCPRepository(HCPDataEntities context) : base(context)
        {
        }
    }
}
