﻿using GestaoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoTarefas.Infra.Arquivos
{
    [Serializable]
    public class RepositorioTarefaEmArquivo : IRepositorioTarefa
    {

        private readonly ISerializadorTarefas serializador;
        List<Tarefa> tarefas = new List<Tarefa>();
        private int contador = 0;

        public RepositorioTarefaEmArquivo(ISerializadorTarefas serializador)
        {
            this.serializador = serializador;

            tarefas = serializador.CarregarTarefasDoArquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Id);
        }


        public List<Tarefa> SelecionarTodos()
        {
            tarefas = serializador.CarregarTarefasDoArquivo();

            return tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Id = ++contador;
            tarefas.Add(novaTarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }
        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                break;
            }
            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }
            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() == 100).ToList();
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() < 100).ToList();
        }
    }
}
