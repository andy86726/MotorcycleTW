using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MotorcycleTW.ViewModel;

namespace MotorcycleTW.Controllers
{
    public class TestController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<RegisterViewModels> Get()
        {
            var result = new RegisterViewModels();
            var list = new List<RegisterViewModels>();

            result.City = "台北市";
            result.arrayLists = new List<ArrayList>();
            result.arrayLists.Add(new ArrayList { AreaName = "中正區", ZipCode = 100 });

            list.Add(result);

            return list;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}