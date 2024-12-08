using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IChisteService
    {
        List<Chiste> GetChistes();
        Chiste GetById(int id);
        void CreateChiste(Chiste chiste);
        void UpdateChiste(Chiste chiste);
        void DeleteChiste(int id);
    }
}
