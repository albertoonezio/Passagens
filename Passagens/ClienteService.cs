using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Add(string nome, string cpf)
        {
            Cliente c = new Cliente();
            c.Nome = nome;
            c.Cpf = cpf;
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            return clienteDAO.Buscar(nome);
        }

        public List<Cliente> GetClientes()
        {
            return ClienteDAO.clientes;
        }
    }
}
