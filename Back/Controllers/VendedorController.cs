using System;
using System.Collections.Generic;
using System.Linq;
using Back.DAO;
using Back.Data;
using Back.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back.Controllers
{
    [ApiController]
    [Route("api/vendedor")]
    public class VendedorController : ControllerBase
    {
        private readonly DataContext _dataContext; 
        private readonly VendedorDAO _vendedorDAO;

        public VendedorController(
            DataContext dataContext,
            VendedorDAO vendedorDAO) 
        {
            _dataContext = dataContext;
            _vendedorDAO = vendedorDAO;
        } 
        
        // GET
        // /api/vendedor
        [HttpGet]
        [Route("")]
        public IActionResult Get() => Ok(_vendedorDAO.List());

        // GET
        // /api/vendedor/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Int32 id)
        {
            Vendedor vendedor = _vendedorDAO.FindById(id);

            if (vendedor == null) return NotFound();
            
            return Ok(vendedor);
        }

        // PUT
        // /api/vendedor
        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Vendedor vendedor)
        {
            _vendedorDAO.Update(vendedor);

            return Ok(vendedor);
        }

        // POST
        // /api/vendedor
        [HttpPost]
        [Route("")]
        public IActionResult Create([FromBody] Vendedor vendedor) 
        {
            _vendedorDAO.Create(vendedor);

            return Created("", vendedor);
        }

        // DELETE
        // /api/vendedor/{id}
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById([FromRoute] Int32 id)
        {
            Boolean vendedorExists = _vendedorDAO.VendedorExists(id);

            if (!vendedorExists) return NotFound();

            _vendedorDAO.Delete(id);

            return Ok(_vendedorDAO.List());
        }
    }
}