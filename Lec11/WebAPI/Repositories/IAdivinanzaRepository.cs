using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IAdivinanzaRepository
    {
        List<Adivinanza> GetAdivinanzas();
        Adivinanza GetById(int id);
        void Add(Adivinanza adivinanza);
        void Update(Adivinanza adivinanza);
        void Delete(int id);
    }
}
