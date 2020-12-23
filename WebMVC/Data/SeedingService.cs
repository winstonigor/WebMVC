using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;


//Serviço para popular o BD
namespace WebMVC.Data
{
    public class SeedingService
    {
        private WebMVCContext _context;

        public SeedingService(WebMVCContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            if(_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVenda.Any())
            {
                return;  //BD já foi populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronico");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Books");

            Vendedor v1 = new Vendedor(1, "Winston", "winstonigorseveriano@hotmail.com", 5000.0, new DateTime(1995, 4, 14), d1);
            Vendedor v2 = new Vendedor(2, "Igor", "igor@hotmail.com", 5100.0, new DateTime(1995, 4, 14), d2);
            Vendedor v3 = new Vendedor(3, "Meiramar", "meiramar@hotmail.com", 5010.0, new DateTime(1995, 4, 14), d3);
            Vendedor v4 = new Vendedor(4, "Valdeir", "valdeir@hotmail.com", 8000.0, new DateTime(1995, 4, 14), d4);

            RegistroVenda r1 = new RegistroVenda(1, new DateTime(2018, 9, 25), 11000.0, Models.Enums.StatusVenda.Faturado, v1);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(v1, v2, v3, v4);
            _context.RegistroVenda.AddRange(r1);
            _context.SaveChanges();

        }

    }
}
