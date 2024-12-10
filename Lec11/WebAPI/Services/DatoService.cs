using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class DatoService : IDatoService
    {
        private readonly IDatoRepository _datoRepository;

        public DatoService(IDatoRepository datoRepository)
        {
            _datoRepository = datoRepository;
        }
        public void CreateDato(Dato dato) => _datoRepository.Add(dato);

        public void DeleteDato(int id) => _datoRepository.Delete(id);

        public Dato GetById(int id) => _datoRepository.GetById(id);

        public List<Dato> GetDatos() => _datoRepository.GetDatos();

        public void UpdateDato(Dato dato) => _datoRepository.Update(dato);
        
    }
}