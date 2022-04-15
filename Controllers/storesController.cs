using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.models;
using api.dataaccess;
using api.interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class storesController : ControllerBase   //enable automatic depolys
    {
        // GET: api/stores
        [HttpGet]
        public List<Store> Get()
        {
            List<Store> myStores = new List<Store>();
            IStoreDataHandler dataHandler = new StoreDataHandlerTest();
            myStores = dataHandler.GetAllStores();
            return myStores;
        }

        // GET: api/stores/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/stores
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/stores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/stores/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
