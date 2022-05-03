using GestaoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroTarefa : Form
    {
        private Tarefa tarefa;
         
        public CadastroTarefa()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                listPrioridade.Text = tarefa.Prioridade;
                txtTitulo.Text = tarefa.Titulo;
            }
        }
  

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (listPrioridade.SelectedIndex == -1)
            {
                listPrioridade.SetSelected(2, true);
            }
            if(txtTitulo.Text == String.Empty)
            {
                MessageBox.Show("Digite um título!", "Cadastro de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tarefa.Titulo = txtTitulo.Text;
            tarefa.Prioridade = listPrioridade.Text;
        }
    }
}
