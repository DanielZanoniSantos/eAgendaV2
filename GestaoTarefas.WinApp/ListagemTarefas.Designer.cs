namespace GestaoTarefas.WinApp
{
    partial class ListagemTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemTarefas));
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrarItens = new System.Windows.Forms.Button();
            this.btnAtualizarItens = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnInserirContatos = new System.Windows.Forms.Button();
            this.btnExcluirContatos = new System.Windows.Forms.Button();
            this.btnEditarContatos = new System.Windows.Forms.Button();
            this.btnAtualizarContatos = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(6, 28);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(63, 47);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(75, 28);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 47);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(140, 28);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(66, 47);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrarItens
            // 
            this.btnCadastrarItens.Location = new System.Drawing.Point(212, 28);
            this.btnCadastrarItens.Name = "btnCadastrarItens";
            this.btnCadastrarItens.Size = new System.Drawing.Size(103, 47);
            this.btnCadastrarItens.TabIndex = 3;
            this.btnCadastrarItens.Text = "Cadastrar Itens";
            this.btnCadastrarItens.UseVisualStyleBackColor = true;
            this.btnCadastrarItens.Click += new System.EventHandler(this.btnCadastrarItens_Click);
            // 
            // btnAtualizarItens
            // 
            this.btnAtualizarItens.Location = new System.Drawing.Point(321, 28);
            this.btnAtualizarItens.Name = "btnAtualizarItens";
            this.btnAtualizarItens.Size = new System.Drawing.Size(103, 47);
            this.btnAtualizarItens.TabIndex = 4;
            this.btnAtualizarItens.Text = "Atualizar Itens";
            this.btnAtualizarItens.UseVisualStyleBackColor = true;
            this.btnAtualizarItens.Click += new System.EventHandler(this.btnAtualizarItens_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 265);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 15;
            this.listTarefasPendentes.Location = new System.Drawing.Point(3, 6);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(397, 229);
            this.listTarefasPendentes.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluídas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 15;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(6, 6);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(433, 214);
            this.listTarefasConcluidas.TabIndex = 6;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(465, 414);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnInserir);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Controls.Add(this.btnEditar);
            this.tabPage3.Controls.Add(this.btnAtualizarItens);
            this.tabPage3.Controls.Add(this.btnExcluir);
            this.tabPage3.Controls.Add(this.btnCadastrarItens);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(457, 386);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Tarefas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listContatos);
            this.tabPage4.Controls.Add(this.btnAtualizarContatos);
            this.tabPage4.Controls.Add(this.btnEditarContatos);
            this.tabPage4.Controls.Add(this.btnExcluirContatos);
            this.tabPage4.Controls.Add(this.btnInserirContatos);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(457, 386);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Contatos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(457, 386);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Compromissos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnInserirContatos
            // 
            this.btnInserirContatos.Location = new System.Drawing.Point(20, 27);
            this.btnInserirContatos.Name = "btnInserirContatos";
            this.btnInserirContatos.Size = new System.Drawing.Size(63, 46);
            this.btnInserirContatos.TabIndex = 0;
            this.btnInserirContatos.Text = "Inserir";
            this.btnInserirContatos.UseVisualStyleBackColor = true;
            this.btnInserirContatos.Click += new System.EventHandler(this.btnInserirContatos_Click);
            // 
            // btnExcluirContatos
            // 
            this.btnExcluirContatos.Location = new System.Drawing.Point(198, 27);
            this.btnExcluirContatos.Name = "btnExcluirContatos";
            this.btnExcluirContatos.Size = new System.Drawing.Size(63, 46);
            this.btnExcluirContatos.TabIndex = 1;
            this.btnExcluirContatos.Text = "Excluir";
            this.btnExcluirContatos.UseVisualStyleBackColor = true;
            // 
            // btnEditarContatos
            // 
            this.btnEditarContatos.Location = new System.Drawing.Point(105, 27);
            this.btnEditarContatos.Name = "btnEditarContatos";
            this.btnEditarContatos.Size = new System.Drawing.Size(63, 46);
            this.btnEditarContatos.TabIndex = 3;
            this.btnEditarContatos.Text = "Editar";
            this.btnEditarContatos.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarContatos
            // 
            this.btnAtualizarContatos.Location = new System.Drawing.Point(289, 27);
            this.btnAtualizarContatos.Name = "btnAtualizarContatos";
            this.btnAtualizarContatos.Size = new System.Drawing.Size(63, 46);
            this.btnAtualizarContatos.TabIndex = 4;
            this.btnAtualizarContatos.Text = "Atualizar";
            this.btnAtualizarContatos.UseVisualStyleBackColor = true;
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(20, 97);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(411, 274);
            this.listContatos.TabIndex = 5;
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 440);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListagemTarefas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrarItens;
        private System.Windows.Forms.Button btnAtualizarItens;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button btnAtualizarContatos;
        private System.Windows.Forms.Button btnEditarContatos;
        private System.Windows.Forms.Button btnExcluirContatos;
        private System.Windows.Forms.Button btnInserirContatos;
    }
}