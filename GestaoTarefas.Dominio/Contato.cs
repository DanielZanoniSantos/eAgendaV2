using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.Dominio
{
    [Serializable]
    public class Contato
    {
        
        public Contato()
        {

        }

        public Contato(string n, string email, string telefone, string cargo) : this()
        {
            Nome = n;
            Email = email;
            Telefone = telefone;
            Empresa = null;
            Cargo = cargo;
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }    
        public string? Empresa { get; set; }
        public string? Cargo { get; set; }

        public override string ToString()
        {
            if (Empresa == null || Cargo == null)
            {
                return $"Nome: {Nome}, E-mail: {Email}, Telefone: {Telefone}";
            }
            return $"Nome: {Nome}, E-mail: {Email}, Telefone: {Telefone}," +
                $" Empresa: {Empresa}, Cargo: {Cargo}";
        }
    }
}
