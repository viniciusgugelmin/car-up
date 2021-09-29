using Back.Models;
using System.Collections.Generic;
using System.Linq;
using Back.Data;

namespace Back.DAO
{
  public class ModeloDAO
  {
    private readonly DataContext _dataContext;

    public ModeloDAO(DataContext dataContext) 
            => _dataContext = dataContext;

    public List<Modelo> List() => _dataContext.Modelos.ToList();

    public Modelo FindById(int id) => _dataContext.Modelos.Find(id);

    public bool ModeloExists(int? id)
    {
        return _dataContext.Modelos.Any(a => a.Id == id);
    }

    public void Create(Modelo Modelo)
    {
        _dataContext.Modelos.Add(Modelo);
        _dataContext.SaveChanges();
    }

    public void Update(Modelo modelo)
    {
        _dataContext.Update(modelo);
        _dataContext.SaveChanges();
    }

    public void Delete(int id)
    {
      _dataContext.Modelos.Remove(FindById(id));
      _dataContext.SaveChanges();
    }
  }
}