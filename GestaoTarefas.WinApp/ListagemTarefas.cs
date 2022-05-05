using GestaoTarefas.Dominio;
using Newtonsoft.Json;
using GestaoTarefas.Infra.Arquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoTarefas.Infra.Arquivo;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemTarefas : Form
    {
        private IRepositorioTarefa repositorioTarefa;
        private IRepositorioContato repositorioContato;

        public object ItensAdicionados { get; private set; }

        public ListagemTarefas()
        {
            //SerializadorTarefasEmBinario serializador = new SerializadorTarefasEmBinario();

            //SerializadorTarefasEmXml serializador = new SerializadorTarefasEmXml();

            //SerializadorTarefasEmJson serializador = new SerializadorTarefasEmJson();


            SerializadorTarefasJsonEmDotNet serializador = new SerializadorTarefasJsonEmDotNet();
            repositorioTarefa = new RepositorioTarefaEmArquivo(serializador);

            SerializadorContatosJsonEmDotNet serializadorContato = new SerializadorContatosJsonEmDotNet();
            repositorioContato = new RepositorioContatoEmArquivo(serializadorContato);

            InitializeComponent();
            CarregarTarefas();
            CarregarContatos();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            listTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listTarefasConcluidas.Items.Add(t);
            }


            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listTarefasPendentes.Items.Add(t);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroTarefa tela = new CadastroTarefa();

            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa) listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Seleciona uma tarefa primeiro", "Edição de tarefas", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefa tela = new CadastroTarefa();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Seleciona uma tarefa primeiro", "Exclusão de tarefas", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }


            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();

            }
        }

        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Seleciona uma tarefa primeiro", "Cadastro de Itens", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        private void btnAtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Seleciona uma tarefa primeiro", "Edição de Tarefas", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if(tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;
                
                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }
        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatos.Items.Add(c);
            }
        }

        private void btnInserirContatos_Click_1(object sender, EventArgs e)
        {
            CadastroContato tela = new CadastroContato();

            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            //-
            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();
            }
        }
        private void btnEditarContatos_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Seleciona uma tarefa primeiro", "Edição de tarefas", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new CadastroContato();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }
        private void btnExcluirContatos_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Seleciona um contato primeiro", "Exclusão de Contatos", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }


            DialogResult resultado = MessageBox.Show("Deseja realmente excluir este contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }
    }
}
