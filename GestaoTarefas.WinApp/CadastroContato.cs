using GestaoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroContato : Form
    {
        private Contato contato;
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
                maskedTxtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }

        }
        public bool ValidarEmail(string email)
        {
            Regex check = new Regex(@"^\w+[\w-.]+\@\w{5}\.[a-z]{2,3}$");
            bool valid = false;
            valid = check.IsMatch(email);
            if (valid == true)
                return true;
            else
            {
                MessageBox.Show("Formato de e-mail inválido!");
                return false;
            }
        }
        public void btnGravarContato_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEmail.Text == "" || maskedTxtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Cadastro de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ValidarEmail(txtEmail.Text) == false)
            {
                return;
            }
            else
            {
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = maskedTxtTelefone.Text;
                contato.Empresa = txtEmpresa.Text;
                contato.Cargo = txtCargo.Text;
            }
        }
    }
}
