using Back.Models;
using System.Collections.Generic;
using System.Linq;
using Back.Data;

namespace Back.DAO
{
  public class MarcaDAO
  {
    private readonly DataContext _dataContext;

    public MarcaDAO(DataContext dataContext) 
            => _dataContext = dataContext;

    public List<Marca> List() => _dataContext.Marcas.ToList();

    public Marca FindById(int id) => _dataContext.Marcas.Find(id);

    public bool MarcaExists(int? id)
    {
        return _dataContext.Marcas.Any(a => a.Id == id);
    }

    public void Create(Marca marca)
    {
        _dataContext.Marcas.Add(marca);
        _dataContext.SaveChanges();
    }

    public void Update(Marca marca)
    {
        _dataContext.Update(marca);
        _dataContext.SaveChanges();
    }

    public void Delete(int id)
    {
      _dataContext.Marcas.Remove(FindById(id));
      _dataContext.SaveChanges();
    }
  }
}