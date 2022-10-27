using ControleDeCursos.Data;
using ControleDeCursos.Models;

namespace ControleDeCursos.Repositories;

public class LeadRepository
{
    protected readonly ApplicationDataContext _context;

    public LeadRepository(ApplicationDataContext context)
    {
        this._context = context;
    }

    // public bool Create()
    // {

    // }

    // public IEnumerable<Lead> GetAll()
    // {

    // }

    // public Lead GetById(int id)
    // {

    // }

    // public Lead GetByEmail(string email)
    // {

    // }

    // public Lead Update(int id)
    // {

    // }

    // public bool Delete(int id)
    // {

    // }
}