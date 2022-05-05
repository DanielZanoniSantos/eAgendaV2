using GestaoTarefas.Dominio;
using System.Collections.Generic;

namespace GestaoTarefas.Infra.Arquivo
{
    public interface ISerializadorContatos
    {
        List<Contato> CarregarContatosDoArquivo();
        void GravarContatosEmArquivo(List<Contato> contatos);
    }
}
