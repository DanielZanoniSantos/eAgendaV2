using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.Dominio
{
    public interface IRepositorioContato
    {
        void Editar(Contato contato);
        void Excluir(Contato contato);
        void Inserir(Contato contato);
        List<Contato> SelecionarTodos();
    }
}
