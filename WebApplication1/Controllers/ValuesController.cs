using Mapster;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            //MapsterMapper.IMapper MapsterMapper = new MapsterMapper.Mapper(GetTypeAdapterConfig());
            

            Source1 source = new Source1 { SourceProp = "SourceProp", Name = "Name" };

            using(var scope = new MapContextScope())
            {
               // MapContext.Current = new MapContext();
                //MapContext.Current.Parameters.Add("Name", "Name");
                scope.Context.Parameters.Add("Name", "Name");               
                var destination = source.Adapt<Destination1>();
            }


            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
       
    }
}
