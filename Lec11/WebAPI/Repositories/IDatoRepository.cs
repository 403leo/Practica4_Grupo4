using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IDatoRepository
    {
        List<Dato> GetDatos();
        Dato GetById(int id);
        void Add(Dato dato);
        void Update(Dato dato);
        void Delete(int id);
    }
}
