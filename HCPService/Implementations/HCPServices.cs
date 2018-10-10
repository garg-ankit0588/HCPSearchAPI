using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCPModels;
using HCPData;
using HCPService.Interfaces;
using HCPRepositories;
using HCPModels;


namespace HCPService.Implementations
{
    public class HCPServices : IHCPService
    {
        //HCPDataEntities hcpRepo = new HCPDataEntities();

        public IEnumerable<HCPModel> GetAllHCPsResult()
        {
            try
            {
                //var result = from h in hcpRepo.HCPDatas
                //             select new HCPModel()
                //             {
                //                 HCPId = h.HCPId,
                //                 FirstName = h.First_Name,
                //                 LastName = h.Last_Name,
                //                 Speciality = h.Speciality
                //             };

                //return result;
                IEnumerable<HCPModel> result;
                using (var unitOfWork = new UnitOfWork(new HCPDataEntities()))
                {
                    result = unitOfWork.HCPs.GetAll().Select(m => new HCPModel {
                        HCPId = m.HCPId,
                        FirstName = m.First_Name,
                        LastName = m.Last_Name,
                        Speciality = m.Speciality
                    });
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

