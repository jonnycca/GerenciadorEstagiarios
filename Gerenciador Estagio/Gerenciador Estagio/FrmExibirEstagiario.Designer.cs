namespace Gerenciador_Estagio
{
    partial class FrmExibirEstagiario
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
            this.DgvEstagiarios = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.ID_ESTAGIARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERÍODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstagiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEstagiarios
            // 
            this.DgvEstagiarios.AllowUserToAddRows = false;
            this.DgvEstagiarios.AllowUserToDeleteRows = false;
            this.DgvEstagiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstagiarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ESTAGIARIO,
            this.NOME,
            this.CURSO,
            this.PERÍODO,
            this.TELEFONE,
            this.DATA_INICIO});
            this.DgvEstagiarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEstagiarios.Location = new System.Drawing.Point(0, 0);
            this.DgvEstagiarios.Name = "DgvEstagiarios";
            this.DgvEstagiarios.ReadOnly = true;
            this.DgvEstagiarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvEstagiarios.Size = new System.Drawing.Size(815, 355);
            this.DgvEstagiarios.TabIndex = 0;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(647, 12);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 1;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(728, 12);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // ID_ESTAGIARIO
            // 
            this.ID_ESTAGIARIO.DataPropertyName = "ID_ESTAGIARIO";
            this.ID_ESTAGIARIO.HeaderText = "ID_ESTÁGIARIO";
            this.ID_ESTAGIARIO.Name = "ID_ESTAGIARIO";
            this.ID_ESTAGIARIO.ReadOnly = true;
            this.ID_ESTAGIARIO.Visible = false;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOME.DataPropertyName = "NOME_ESTAGIARIO";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 60;
            // 
            // CURSO
            // 
            this.CURSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CURSO.DataPropertyName = "CURSO";
            this.CURSO.HeaderText = "Curso";
            this.CURSO.Name = "CURSO";
            this.CURSO.ReadOnly = true;
            this.CURSO.Width = 59;
            // 
            // PERÍODO
            // 
            this.PERÍODO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERÍODO.DataPropertyName = "PERIODO";
            this.PERÍODO.HeaderText = "Período";
            this.PERÍODO.Name = "PERÍODO";
            this.PERÍODO.ReadOnly = true;
            this.PERÍODO.Width = 70;
            // 
            // TELEFONE
            // 
            this.TELEFONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "Telefone";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Width = 74;
            // 
            // DATA_INICIO
            // 
            this.DATA_INICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATA_INICIO.DataPropertyName = "DATA_INICIO";
            this.DATA_INICIO.HeaderText = "Data início";
            this.DATA_INICIO.Name = "DATA_INICIO";
            this.DATA_INICIO.ReadOnly = true;
            this.DATA_INICIO.Width = 84;
            // 
            // FrmExibirEstagiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 355);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.DgvEstagiarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmExibirEstagiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estágiarios";
            this.Load += new System.EventHandler(this.FrmExibirEstagiario_Load);
            this.Shown += new System.EventHandler(this.FrmExibirEstagiario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstagiarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstagiarios;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ESTAGIARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERÍODO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_INICIO;
    }
}