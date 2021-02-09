using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class VendedorService
    {

        private readonly WebMVCContext _context;

        public VendedorService(WebMVCContext context)
        {
            _context = context;
        }

        //retornar todos os vendedores
        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        } 
        
        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        

        public Vendedor FindBayId(int id)
        {
            return _context.Vendedor.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remover (int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();

        }

    }
}
