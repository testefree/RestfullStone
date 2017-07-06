using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfullStone.Models;

namespace RestfullStone.Controllers
{
    public class ClienteController : ApiController
    {

        private readonly Cliente[] Clientes = new Cliente[]
        {
           new Cliente { ID = 1, Nome = "Vagton Alves Ferreira", Email = "vagtonaf@gmail.com", Ativo = true },
           new Cliente { ID = 2, Nome = "Luciano Huck", Email = "lucianoh@globo.com", Ativo = true },
           new Cliente { ID = 3, Nome = "Leonard Nimoy", Email = "leonardnimoy@startrek.com", Ativo = false }
        };

        public Cliente[] Get()
        {
            return Clientes;
        }

        public Cliente Get(int id)
        {

            var clientes = Clientes;
            return clientes.SingleOrDefault(x => x.ID == id);

        }

        // GET: api/Cliente
        /*
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "value";
        }
        */

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
