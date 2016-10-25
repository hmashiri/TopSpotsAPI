using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SanDiegoTopSpots.Models;
using Newtonsoft.Json;
using System.IO;

namespace SanDiegoTopSpots.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<Models.TopSpot> Get()
        {
            var TopSpotInfo = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(File.ReadAllText("C:/Users/hadji/ORIGIN/TopSpotsAPI/topspots.json"));
            return TopSpotInfo;
        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpots
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
