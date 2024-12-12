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
            new Adivinanza { Id = 1, Name = "Adivinanza 1", Description = "¿Qué se encuentra una vez en un minuto, dos veces en un momento pero ninguno en cien años?", RespuestaCorrecta = "La letra m" },
            new Adivinanza { Id = 2, Name = "Adivinanza 2", Description = "Blanca por dentro, verde por fuera. Si quieres que te lo diga, espera.", RespuestaCorrecta = "La pera" },
            new Adivinanza { Id = 3, Name = "Adivinanza 3", Description = "Oro parece, plata no es. Quien no lo adivine, bien tonto es.", RespuestaCorrecta = "El plátano" }
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