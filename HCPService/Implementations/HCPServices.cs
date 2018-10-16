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
using AutoMapper;

namespace HCPService.Implementations
{
    public class HCPServices : IHCPService
    {
        //HCPDataEntities hcpRepo = new HCPDataEntities();

        public IEnumerable<HCPModel> GetAllHCPsResult()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new HCPDataEntities()))
                {
                    //var result = unitOfWork.HCPs.GetAll().Select(m => new HCPModel
                    //{
                    //    HCPId = m.HCPId,
                    //    FirstName = m.FirstName,
                    //    LastName = m.LastName,
                    //    SpecialityName = m.SpecialityMaster.SpecialityName
                    //});

                    var result = unitOfWork.HCPs.GetAll();
                    result = Mapper.Map<HCPData.HCPData, IEnumerable<HCPModel>>(result);
                    result = Mapper.Map<IEnumerable<HCPModel>, HCPData.HCPData>(result);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public HCPModel GetHCPResultById(int Id)
        {
            try
            {
                ////var result = GetAllHCPsResult();
                //result = result.Where(m => m.HCPId == Id);
                //return (HCPModel)result;
                ////return null;
                using (var unitOfWork = new UnitOfWork(new HCPDataEntities()))
                {
                    var result = unitOfWork.HCPs.Get(Id);
                    //var hcp = new HCPModel
                    //{
                    //    HCPId = result.HCPId,
                    //};

                    result  = Mapper.Map<HCPData.HCPData, HCPModel>(result);
                    result = Mapper.Map< HCPModel, HCPData.HCPData>(result);
                }

                return null;


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

