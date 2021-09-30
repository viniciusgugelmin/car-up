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
    [Route("api/modelo")]
    public class ModeloController : ControllerBase
    {
        private readonly DataContext _dataContext; 
        private readonly ModeloDAO _modeloDAO;

        public ModeloController(
            DataContext dataContext,
            ModeloDAO modeloDAO) 
        {
            _dataContext = dataContext;
            _modeloDAO = modeloDAO;
        } 
        
        // GET
        // /api/modelo
        [HttpGet]
        [Route("")]
        public IActionResult Get() => Ok(_modeloDAO.List());

        // GET
        // /api/modelo/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Int32 id)
        {
            Modelo modelo = _modeloDAO.FindById(id);

            if (modelo == null) return NotFound();
            
            return Ok(modelo);
        }

        // GET
        // /api/modelo/{id}/veiculos
        [HttpGet]
        [Route("{id}/veiculos")]
        public IActionResult GetVeiculos([FromRoute] Int32 id)
        {
            Modelo modelo = _modeloDAO.FindById(id);

            if (modelo == null) return NotFound();
            
            return Ok(modelo.Veiculo);
        }

        // PUT
        // /api/modelo
        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Modelo modelo)
        {
            _modeloDAO.Update(modelo);

            return Ok(modelo);
        }

        // POST
        // /api/modelo
        [HttpPost]
        [Route("")]
        public IActionResult Create([FromBody] Modelo modelo) 
        {
            _modeloDAO.Create(modelo);

            return Created("", modelo);
        }

        // DELETE
        // /api/modelo/{id}
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById([FromRoute] Int32 id)
        {
            Boolean modeloExists = _modeloDAO.ModeloExists(id);

            if (!modeloExists) return NotFound();

            _modeloDAO.Delete(id);

            return Ok(_modeloDAO.List());
        }
    }
}