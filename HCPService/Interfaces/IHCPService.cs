using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCPModels;

namespace HCPService.Interfaces
{
    public interface IHCPService
    {
        IEnumerable<HCPModel> GetAllHCPsResult();
    }
}
