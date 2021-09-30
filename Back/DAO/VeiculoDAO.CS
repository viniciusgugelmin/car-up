using Back.Models;
using System.Collections.Generic;
using System.Linq;
using Back.Data;
using Microsoft.EntityFrameworkCore;

namespace Back.DAO
{
  public class VeiculoDAO
  {
    private readonly DataContext _dataContext;

    public VeiculoDAO(DataContext dataContext) 
            => _dataContext = dataContext;

    public List<Veiculo> List() => _dataContext.Veiculos.ToList();

    public Veiculo FindById(int id) 
    {
        return _dataContext.Veiculos.Find(id);
    } 

    public Veiculo FindWithModelos(int id)
    {
        Veiculo veiculo = _dataContext.Veiculos.Find(id);
        _dataContext.Veiculos.Include(v => v.Modelo).Load();

        return veiculo;
            
    }

    public bool VeiculoExists(int? id)
    {
        return _dataContext.Veiculos.Any(a => a.Id == id);
    }

    public void Create(Veiculo veiculo)
    {
        _dataContext.Veiculos.Add(veiculo);
        _dataContext.SaveChanges();
    }

    public void Update(Veiculo veiculo)
    {
        _dataContext.Update(veiculo);
        _dataContext.SaveChanges();
    }

    public void Delete(int id)
    {
      _dataContext.Veiculos.Remove(FindById(id));
      _dataContext.SaveChanges();
    }
  }
}