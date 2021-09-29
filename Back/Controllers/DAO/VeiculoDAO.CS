using Back.Veiculos;
using System.Collections.Generic;
using System.Linq;
using Back.Data;

namespace Back.DAO
{
  public class VeiculosDAO
  {
    private readonly DataContext _dataContext;

    public VeiculosDAO(DataContext dataContext) 
            => _dataContext = dataContext;

    public List<Veiculos> List() => _dataContext.Veiculos.ToList();

    public Veiculos FindById(int id) => _dataContext.Veiculoss.Find(id);

    public bool VeiculosExists(int? id)
    {
        return _dataContext.Veiculoss.Any(a => a.Id == id);
    }

    public void Create(Veiculos Veiculos)
    {
        _dataContext.Veiculoss.Add(Veiculos);
        _dataContext.SaveChanges();
    }

    public void Update(Veiculos Veiculos)
    {
        _dataContext.Update(Veiculos);
        _dataContext.SaveChanges();
    }

    public void Delete(int id)
    {
      _dataContext.Veiculoss.Remove(FindById(id));
      _dataContext.SaveChanges();
    }
  }