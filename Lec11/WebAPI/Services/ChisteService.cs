using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class ChisteService : IChisteService
    {
        private readonly IChisteRepository _chisteRepository;

        public ChisteService(IChisteRepository chisteRepository)
        {
            _chisteRepository = chisteRepository;
        }
        public void CreateChiste(Chiste chiste) => _chisteRepository.Add(chiste);

        public void DeleteChiste(int id) => _chisteRepository.Delete(id);

        public Chiste GetById(int id) => _chisteRepository.GetById(id);

        public List<Chiste> GetChistes() => _chisteRepository.GetChistes(); 
         
        public void UpdateChiste(Chiste chiste) => _chisteRepository.Update(chiste);
    }
}