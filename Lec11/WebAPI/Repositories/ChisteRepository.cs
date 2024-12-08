using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class ChisteRepository : IChisteRepository
    {
        private static List<Chiste> chistes = new List<Chiste>
        {
            new Chiste { Id = 1, Name = " Chiste 1", Description = "- Dime con quién andas y te diré quién eres.\r\n- No ando con nadie...\r\n- Eres feo." },
            new Chiste { Id = 2, Name = " Chiste 2", Description = "- Andresito, ¿qué planeta va después de Marte?\r\n- Miércole, señorita." },
            new Chiste { Id = 3, Name = " Chiste 3", Description = "- ¿Por qué Bob Esponja no va al gimnasio?\r\n- Porque ya está cuadrado." }
        };

        public List<Chiste> GetChistes() => chistes;

        public Chiste GetById(int id) => chistes.FirstOrDefault(p => p.Id == id);

        public void Add(Chiste chiste) => chistes.Add(chiste);

        public void Update(Chiste chiste)
        {
            var existing = chistes.FirstOrDefault(p => p.Id == chiste.Id);
            if (existing != null)
            {
                existing.Name = chiste.Name;
                existing.Description = chiste.Description;
            }
        }

        public void Delete(int id) => chistes.RemoveAll(p => p.Id == id);
    }
}