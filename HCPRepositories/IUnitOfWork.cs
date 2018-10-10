using HCPRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCPRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        IHCPRepository HCPs { get; }

    }
}
