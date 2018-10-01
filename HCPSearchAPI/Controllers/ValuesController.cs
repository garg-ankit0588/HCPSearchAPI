using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HCPModels;
namespace HCPSearchAPI.Controllers
{
    public class ValuesController : ApiController
    {
        IList<HCPModel> hcpList = new List<HCPModel>
        {
            new HCPModel()
            {
                HCPId = 1, FirstName ="john", LastName="Doe", Speciality="MBBS"
            }
        };
        // GET api/values
        public IList<HCPModel> Get()
        {
            return hcpList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
