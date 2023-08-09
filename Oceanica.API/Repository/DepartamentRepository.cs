using Oceanica.API.Data;
using Oceanica.API.Models;
using Oceanica.API.Repository.Abstract;
using System.Reflection.Metadata.Ecma335;

namespace Oceanica.API.Repository;

public class DepartamentRepository : IRepository<Departament>
{
    public OceanicaContext Context;

    public DepartamentRepository(OceanicaContext context) => Context = context;

    public ICollection<Departament> GetAll(int skip, int take)
    {
        return Context.Departaments.Skip(skip).Take(take).ToList();
    }

    public Departament GetById(int id)
    {
        return Context.Departaments.Find(id);
    }

    public Departament Insert(Departament entity)
    {
        Context.Departaments.Add(entity);
        Context.SaveChanges();
        return entity;
    }

    public Departament Update(Departament entity)
    {
        var entityFound = Context.Departaments.Find(entity.Id);
        if (entityFound == null)
            return null;

        Context.Entry(entityFound).CurrentValues.SetValues(entity);

        Context.SaveChangesAsync();
        return entityFound;
    }

    public void DeleteById(int id)
    {
        var entity = GetById(id);
        Context.Departaments.Remove(entity);
    }
}
