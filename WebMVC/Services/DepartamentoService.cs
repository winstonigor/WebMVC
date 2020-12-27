using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class DepartamentoService
    {
        private readonly WebMVCContext _context;

        public DepartamentoService(WebMVCContext context)
        {
            _context = context;
        }

        //retornar todos os Departamento ordenado por nome
        public List<Departamento> FindAll()
        {
            //return _context.Departamento.ToList();
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }

        public void Insert(Departamento obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
