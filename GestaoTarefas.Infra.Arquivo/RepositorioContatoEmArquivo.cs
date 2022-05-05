using GestaoTarefas.Dominio;
using System;
using System.Collections.Generic;

namespace GestaoTarefas.Infra.Arquivo
{
    [Serializable]
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {

        private readonly ISerializadorContatos serializador;
        List<Contato> contatos = new List<Contato>();
        
        public RepositorioContatoEmArquivo(ISerializadorContatos serializador)
        {
            this.serializador = serializador;

            contatos = serializador.CarregarContatosDoArquivo();
        }
        public List<Contato> SelecionarTodos()
        {
            contatos = serializador.CarregarContatosDoArquivo();

            return contatos;
        }
        public void Inserir(Contato novoContato)
        {
            contatos.Add(novoContato);

            serializador.GravarContatosEmArquivo(contatos);
        }
        public void Editar(Contato contato)
        {
            foreach(var item in contatos)
            {
                break;
            }
            serializador.GravarContatosEmArquivo(contatos);
        }
        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
            serializador.GravarContatosEmArquivo(contatos);
        }
    }
}
