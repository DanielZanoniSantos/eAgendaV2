using GestaoTarefas.Dominio;
using System.Collections.Generic;

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
