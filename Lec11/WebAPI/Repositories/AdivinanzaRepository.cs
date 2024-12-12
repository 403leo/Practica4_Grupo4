using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class AdivinanzaRepository : IAdivinanzaRepository
    {
        private static List<Adivinanza> adivinanzas = new List<Adivinanza>
        {
            new Adivinanza { Id = 1, Name = " Adivinanza 1", Description = "- Blanca por dentro, verde por fuera. Si quieres que te lo diga, espera.\r\n- El aguacate" },
            new Adivinanza { Id = 2, Name = " Adivinanza 2", Description = "- Tengo hojas pero no soy árbol, tengo lomo pero no soy animal. ¿Qué soy?.\r\n- El libro" },
            new Adivinanza { Id = 3, Name = " Adivinanza 3", Description = "- Cien amigos tengo, todos en fila, si uno se pierde, todos lo miran.\r\n- El peine" }
        };

        public List<Adivinanza> GetAdivinanzas() => adivinanzas;

        public Adivinanza GetById(int id) => adivinanzas.FirstOrDefault(a => a.Id == id);

        public void Add(Adivinanza adivinanza) => adivinanzas.Add(adivinanza);

        public void Update(Adivinanza adivinanza)
        {
            var existing = adivinanzas.FirstOrDefault(a => a.Id == adivinanza.Id);
            if (existing != null)
            {
                existing.Name = adivinanza.Name;
                existing.Description = adivinanza.Description;
            }
        }

        public void Delete(int id) => adivinanzas.RemoveAll(a => a.Id == id);
    }
}