using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IChisteRepository
    {
        List<Chiste> GetChistes();
        Chiste GetById(int id);
        void Add(Chiste chiste);
        void Update(Chiste chiste);
        void Delete(int id);
    }
}
