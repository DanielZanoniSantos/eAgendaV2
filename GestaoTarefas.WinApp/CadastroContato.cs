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
    public partial class CadastroContato : Form
    {
        public Contato contato;
        public CadastroContato()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }

        }

        public void btnGravarContato_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;  
            contato.Telefone = txtTelefone.Text;
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;
        }
    }
}
