using Back.Models;
using System.Collections.Generic;
using System.Linq;
using Back.Data;
using Microsoft.EntityFrameworkCore;


namespace Back.DAO
{
  public class VendedorDAO
  {
    private readonly DataContext _dataContext;

    public VendedorDAO(DataContext dataContext) 
            => _dataContext = dataContext;

    public List<Vendedor> List() => _dataContext.Vendedores.ToList();

    public Vendedor FindById(int id) 
    {
        return _dataContext.Vendedores.Find(id);
    }

    public bool VendedorExists(int? id)
    {
        return _dataContext.Vendedores.Any(a => a.Id == id);
    }

    public void Create(Vendedor vendedor)
    {
        _dataContext.Vendedores.Add(vendedor);
        _dataContext.SaveChanges();
    }

    public void Update(Vendedor vendedor)
    {
        _dataContext.Update(vendedor);
        _dataContext.SaveChanges();
    }

    public void Delete(int id)
    {
      _dataContext.Vendedores.Remove(FindById(id));
      _dataContext.SaveChanges();
    }
  }
}