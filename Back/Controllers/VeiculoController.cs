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
    [Route("api/veiculo")]
    public class VeiculoController : ControllerBase
    {
        private readonly DataContext _dataContext; 
        private readonly VeiculoDAO _veiculoDAO;

        public VeiculoController(
            DataContext dataContext,
            VeiculoDAO veiculoDAO) 
        {
            _dataContext = dataContext;
            _veiculoDAO = veiculoDAO;
        } 
        
        // GET
        // /api/veiculo
        [HttpGet]
        [Route("")]
        public IActionResult Get() => Ok(_veiculoDAO.List());

        // GET
        // /api/veiculo/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Int32 id)
        {
            Veiculo veiculo = _veiculoDAO.FindWithModelos(id);

            if (veiculo == null) return NotFound();
            
            return Ok(veiculo);
        }

        // PUT
        // /api/veiculo
        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Veiculo veiculo)
        {
            _veiculoDAO.Update(veiculo);

            return Ok(veiculo);
        }

        // POST
        // /api/veiculo
        [HttpPost]
        [Route("")]
        public IActionResult Create([FromBody] Veiculo veiculo) 
        {
            _veiculoDAO.Create(veiculo);

            return Created("", veiculo);
        }

        // DELETE
        // /api/veiculo/{id}
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById([FromRoute] Int32 id)
        {
            Boolean veiculoExists = _veiculoDAO.VeiculoExists(id);

            if (!veiculoExists) return NotFound();

            _veiculoDAO.Delete(id);

            return Ok(_veiculoDAO.List());
        }
    }
}