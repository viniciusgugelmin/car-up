using Back.marca
using System.Collections.Generic;
using System.Linq;
using Back.Data;

namespace Back.DAO
{
  public class MarcaDAO
  {
    private readonly DataContext _dataContext;

    public Marcadao(DataContext dataContext) 
            => _dataContext = dataContext;

    public List<Marca> List() => _dataContext.Marcas.ToList();

    public Marcadao FindById(int id) => _dataContext.Marcadao.Find(id);

    public bool MarcadaoExists(int? id)
    {
        return _dataContext.Marcadao.Any(a => a.Id == id);
    }

    public void Create(Marcadao aMarcadao)
    {
        _dataContext.Marcadao.Add(Marcadao);
        _dataContext.SaveChanges();
    }

    public void Update(Marcadao Marcadao)
    {
        _dataContext.Update(Marcadao);
        _dataContext.SaveChanges();
    }

    public void Delete(int id)
    {
      _dataContext.Administrators.Remove(FindById(id));
      _dataContext.SaveChanges();
    }
  }