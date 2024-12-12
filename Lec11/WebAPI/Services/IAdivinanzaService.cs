using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IAdivinanzaService
    {
        void CreateAdivinanza(Adivinanza adivinanza);
        void DeleteAdivinanza(int id);
        Adivinanza GetById(int id);
        List<Adivinanza> GetAdivinanzas();
        void UpdateAdivinanza(Adivinanza adivinanza);
    }

}
