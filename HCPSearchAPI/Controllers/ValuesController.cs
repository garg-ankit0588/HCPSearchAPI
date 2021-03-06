﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HCPModels;
using HCPService.Interfaces;

namespace HCPSearchAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IHCPService _hcpService;
        public ValuesController(IHCPService hcpService)
        {
            _hcpService = hcpService;
        }
        // GET api/values
        public IEnumerable<HCPModel> Get()
        {

            return _hcpService.GetAllHCPsResult();
        }

        // GET api/values/5
        public HCPModel Get(int id)
        {
            return _hcpService.GetHCPResultById(id);
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
