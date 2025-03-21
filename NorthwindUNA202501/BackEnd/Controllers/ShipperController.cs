﻿using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        IUnidadDeTrabajo unidadDeTrabajo;

        public ShipperController(IUnidadDeTrabajo unidad)
        {
            unidadDeTrabajo = unidad;
        }
        // GET: api/<ShipperController>
        [HttpGet]
        public IEnumerable<Shipper> Get()
        {
            return unidadDeTrabajo.ShipperDAL.Get();
        }

        // GET api/<ShipperController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShipperController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShipperController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShipperController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
