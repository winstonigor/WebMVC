using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>(); //Departamento pode ter varios vendedor 

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // Adicionar um vendedor
        public void AdicionarVendedor (Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }

        //Total de vendas do departamento
        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedor.Sum(Vendedor => Vendedor.TotalVendas(inicial, final));
        }
    }
}
