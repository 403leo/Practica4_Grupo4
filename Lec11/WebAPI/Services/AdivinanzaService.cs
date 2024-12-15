using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class AdivinanzaService : IAdivinanzaService
    {
        private readonly IAdivinanzaRepository _adivinanzaRepository;

        public AdivinanzaService(IAdivinanzaRepository adivinanzaRepository)
        {
            _adivinanzaRepository = adivinanzaRepository;
        }

        public void CreateAdivinanza(Adivinanza adivinanza) => _adivinanzaRepository.Add(adivinanza);

        public void DeleteAdivinanza(int id) => _adivinanzaRepository.Delete(id);

        public Adivinanza GetById(int id) => _adivinanzaRepository.GetById(id);

        public List<Adivinanza> GetAdivinanzas() => _adivinanzaRepository.GetAdivinanzas();

        public void UpdateAdivinanza(Adivinanza adivinanza) => _adivinanzaRepository.Update(adivinanza);
    }
}