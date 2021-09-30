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
    [Route("api/marca")]
    public class MarcaController : ControllerBase
    {
        private readonly DataContext _dataContext; 
        private readonly MarcaDAO _marcaDAO;

        public MarcaController(
            DataContext dataContext,
            MarcaDAO marcaDAO) 
        {
            _dataContext = dataContext;
            _marcaDAO = marcaDAO;
        } 
        
        // GET
        // /api/marca
        [HttpGet]
        [Route("")]
        public IActionResult Get() => Ok(_marcaDAO.List());

        // GET
        // /api/marca/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Int32 id)
        {
            Marca marca = _marcaDAO.FindById(id);

            if (marca == null) return NotFound();
            
            return Ok(marca);
        }

        // GET
        // /api/marca/{id}/modelos
        [HttpGet]
        [Route("{id}/modelos")]
        public IActionResult GetModelos([FromRoute] Int32 id)
        {
            Marca marca = _marcaDAO.FindById(id);

            if (marca == null) return NotFound();
            
            return Ok(marca.Modelo);
        }

        // PUT
        // /api/marca
        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Marca marca)
        {
            _marcaDAO.Update(marca);

            return Ok(marca);
        }

        // POST
        // /api/marca
        [HttpPost]
        [Route("")]
        public IActionResult Create([FromBody] Marca marca) 
        {
            _marcaDAO.Create(marca);

            return Created("", marca);
        }

        // DELETE
        // /api/marca/{id}
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById([FromRoute] Int32 id)
        {
            Boolean marcaExists = _marcaDAO.MarcaExists(id);

            if (!marcaExists) return NotFound();

            _marcaDAO.Delete(id);

            return Ok(_marcaDAO.List());
        }
    }
}