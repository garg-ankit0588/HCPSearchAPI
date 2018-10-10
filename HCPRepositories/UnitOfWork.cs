using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCPRepositories.Interfaces;
using HCPData;
using HCPRepositories.Implementations;

namespace HCPRepositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public HCPDataEntities _context;
        public UnitOfWork(HCPDataEntities context)
        {
            _context = new HCPDataEntities();
            HCPs = new HCPRepository(context);
        }
        public IHCPRepository HCPs { get; private set; }
        

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            //_context.Dispose();
        }
    }
}
