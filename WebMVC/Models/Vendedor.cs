using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double BaseSalarial { get; set; }
        public DateTime DataNascimento { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVenda> RegistroVendas { get; set; } = new List<RegistroVenda>(); // Vendedor tem varios registro de vendas

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, double baseSalarial, DateTime dataNascimento, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BaseSalarial = baseSalarial;
            DataNascimento = dataNascimento;
            Departamento = departamento;
        }


        //Adicionar uma venda na lista de vendas
        public void AddVendedor(RegistroVenda rv)
        {
            RegistroVendas.Add(rv);
        }

        //Remover uma venda do vendedor
        public void RemoveVendedor(RegistroVenda rv)
        {

            RegistroVendas.Remove(rv);

        }

        //Total de vendas
        public Double TotalVendas(DateTime inicial, DateTime final)
        {
            return RegistroVendas.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Total);

        }

    }
}
