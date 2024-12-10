using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IDatoService
    {
        List<Dato> GetDatos();
        Dato GetById(int id);
        void CreateDato(Dato dato);
        void UpdateDato(Dato dato);
        void DeleteDato(int id);
    }
}
