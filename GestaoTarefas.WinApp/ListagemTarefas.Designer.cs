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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInserirContatos = new System.Windows.Forms.Button();
            this.btnExcluirContatos = new System.Windows.Forms.Button();
            this.btnEditarContatos = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listCompromissos = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnInserirCompromissos = new System.Windows.Forms.Button();
            this.btnExcluirCompromissos = new System.Windows.Forms.Button();
            this.btnEditarCompromissos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(0, 88);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(160, 38);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(0, 132);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 38);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Location = new System.Drawing.Point(0, 176);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 38);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrarItens
            // 
            this.btnCadastrarItens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarItens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarItens.Location = new System.Drawing.Point(0, 218);
            this.btnCadastrarItens.Name = "btnCadastrarItens";
            this.btnCadastrarItens.Size = new System.Drawing.Size(160, 38);
            this.btnCadastrarItens.TabIndex = 3;
            this.btnCadastrarItens.Text = "Cadastrar Itens";
            this.btnCadastrarItens.UseVisualStyleBackColor = true;
            this.btnCadastrarItens.Click += new System.EventHandler(this.btnCadastrarItens_Click);
            // 
            // btnAtualizarItens
            // 
            this.btnAtualizarItens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarItens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizarItens.Location = new System.Drawing.Point(0, 263);
            this.btnAtualizarItens.Name = "btnAtualizarItens";
            this.btnAtualizarItens.Size = new System.Drawing.Size(160, 38);
            this.btnAtualizarItens.TabIndex = 4;
            this.btnAtualizarItens.Text = "Atualizar Itens";
            this.btnAtualizarItens.UseVisualStyleBackColor = true;
            this.btnAtualizarItens.Click += new System.EventHandler(this.btnAtualizarItens_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(169, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 387);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 359);
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
            this.listTarefasPendentes.Size = new System.Drawing.Size(670, 349);
            this.listTarefasPendentes.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluídas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 15;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(3, 6);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(670, 349);
            this.listTarefasConcluidas.TabIndex = 6;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(867, 421);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(859, 393);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Tarefas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnInserir);
            this.panel3.Controls.Add(this.btnAtualizarItens);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnCadastrarItens);
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 397);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 82);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.listContatos);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(859, 393);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Contatos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnInserirContatos);
            this.panel1.Controls.Add(this.btnExcluirContatos);
            this.panel1.Controls.Add(this.btnEditarContatos);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 397);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 82);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnInserirContatos
            // 
            this.btnInserirContatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserirContatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserirContatos.ForeColor = System.Drawing.Color.Transparent;
            this.btnInserirContatos.Location = new System.Drawing.Point(0, 88);
            this.btnInserirContatos.Name = "btnInserirContatos";
            this.btnInserirContatos.Size = new System.Drawing.Size(160, 38);
            this.btnInserirContatos.TabIndex = 0;
            this.btnInserirContatos.Text = "Inserir";
            this.btnInserirContatos.UseVisualStyleBackColor = true;
            this.btnInserirContatos.Click += new System.EventHandler(this.btnInserirContatos_Click_1);
            // 
            // btnExcluirContatos
            // 
            this.btnExcluirContatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirContatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirContatos.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcluirContatos.Location = new System.Drawing.Point(0, 176);
            this.btnExcluirContatos.Name = "btnExcluirContatos";
            this.btnExcluirContatos.Size = new System.Drawing.Size(160, 38);
            this.btnExcluirContatos.TabIndex = 1;
            this.btnExcluirContatos.Text = "Excluir";
            this.btnExcluirContatos.UseVisualStyleBackColor = true;
            this.btnExcluirContatos.Click += new System.EventHandler(this.btnExcluirContatos_Click);
            // 
            // btnEditarContatos
            // 
            this.btnEditarContatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarContatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarContatos.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditarContatos.Location = new System.Drawing.Point(0, 132);
            this.btnEditarContatos.Name = "btnEditarContatos";
            this.btnEditarContatos.Size = new System.Drawing.Size(160, 38);
            this.btnEditarContatos.TabIndex = 3;
            this.btnEditarContatos.Text = "Editar";
            this.btnEditarContatos.UseVisualStyleBackColor = true;
            this.btnEditarContatos.Click += new System.EventHandler(this.btnEditarContatos_Click);
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(165, 6);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(688, 379);
            this.listContatos.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage5.Controls.Add(this.listCompromissos);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(859, 393);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Compromissos";
            // 
            // listCompromissos
            // 
            this.listCompromissos.FormattingEnabled = true;
            this.listCompromissos.ItemHeight = 15;
            this.listCompromissos.Location = new System.Drawing.Point(162, 6);
            this.listCompromissos.Name = "listCompromissos";
            this.listCompromissos.Size = new System.Drawing.Size(688, 379);
            this.listCompromissos.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnInserirCompromissos);
            this.panel5.Controls.Add(this.btnExcluirCompromissos);
            this.panel5.Controls.Add(this.btnEditarCompromissos);
            this.panel5.Location = new System.Drawing.Point(-4, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 393);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(158, 82);
            this.panel6.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnInserirCompromissos
            // 
            this.btnInserirCompromissos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserirCompromissos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserirCompromissos.ForeColor = System.Drawing.Color.Transparent;
            this.btnInserirCompromissos.Location = new System.Drawing.Point(0, 88);
            this.btnInserirCompromissos.Name = "btnInserirCompromissos";
            this.btnInserirCompromissos.Size = new System.Drawing.Size(160, 38);
            this.btnInserirCompromissos.TabIndex = 0;
            this.btnInserirCompromissos.Text = "Inserir";
            this.btnInserirCompromissos.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCompromissos
            // 
            this.btnExcluirCompromissos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirCompromissos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCompromissos.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcluirCompromissos.Location = new System.Drawing.Point(0, 176);
            this.btnExcluirCompromissos.Name = "btnExcluirCompromissos";
            this.btnExcluirCompromissos.Size = new System.Drawing.Size(160, 38);
            this.btnExcluirCompromissos.TabIndex = 1;
            this.btnExcluirCompromissos.Text = "Excluir";
            this.btnExcluirCompromissos.UseVisualStyleBackColor = true;
            // 
            // btnEditarCompromissos
            // 
            this.btnEditarCompromissos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCompromissos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCompromissos.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditarCompromissos.Location = new System.Drawing.Point(0, 132);
            this.btnEditarCompromissos.Name = "btnEditarCompromissos";
            this.btnEditarCompromissos.Size = new System.Drawing.Size(160, 38);
            this.btnEditarCompromissos.TabIndex = 3;
            this.btnEditarCompromissos.Text = "Editar";
            this.btnEditarCompromissos.UseVisualStyleBackColor = true;
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 421);
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
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button btnEditarContatos;
        private System.Windows.Forms.Button btnExcluirContatos;
        private System.Windows.Forms.Button btnInserirContatos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnInserirCompromissos;
        private System.Windows.Forms.Button btnExcluirCompromissos;
        private System.Windows.Forms.Button btnEditarCompromissos;
        private System.Windows.Forms.ListBox listCompromissos;
    }
}