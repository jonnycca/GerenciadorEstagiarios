namespace Gerenciador_Estagio
{
    partial class FrmExibirAtividades
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
            this.DgvAtividades = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.ID_ATIVIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROBLEMA_RESOLVER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_SOLUCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtividades)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAtividades
            // 
            this.DgvAtividades.AllowUserToAddRows = false;
            this.DgvAtividades.AllowUserToDeleteRows = false;
            this.DgvAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAtividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ATIVIDADE,
            this.TITULO,
            this.PROBLEMA_RESOLVER,
            this.DESCRICAO_SOLUCAO,
            this.SETOR,
            this.DATA_REGISTRO,
            this.ESTADO});
            this.DgvAtividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAtividades.Location = new System.Drawing.Point(0, 0);
            this.DgvAtividades.Name = "DgvAtividades";
            this.DgvAtividades.ReadOnly = true;
            this.DgvAtividades.Size = new System.Drawing.Size(903, 502);
            this.DgvAtividades.TabIndex = 0;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(807, 28);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 1;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(704, 28);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // ID_ATIVIDADE
            // 
            this.ID_ATIVIDADE.DataPropertyName = "ID_ATIVIDADE";
            this.ID_ATIVIDADE.HeaderText = "ID ATIVIDADE";
            this.ID_ATIVIDADE.Name = "ID_ATIVIDADE";
            this.ID_ATIVIDADE.ReadOnly = true;
            this.ID_ATIVIDADE.Visible = false;
            // 
            // TITULO
            // 
            this.TITULO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TITULO.DataPropertyName = "TITULO";
            this.TITULO.HeaderText = "TÍTULO";
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            this.TITULO.Width = 71;
            // 
            // PROBLEMA_RESOLVER
            // 
            this.PROBLEMA_RESOLVER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PROBLEMA_RESOLVER.DataPropertyName = "PROBLEMA_RESOLVER";
            this.PROBLEMA_RESOLVER.HeaderText = "PROBLEMA A RESOLVER";
            this.PROBLEMA_RESOLVER.Name = "PROBLEMA_RESOLVER";
            this.PROBLEMA_RESOLVER.ReadOnly = true;
            this.PROBLEMA_RESOLVER.Width = 148;
            // 
            // DESCRICAO_SOLUCAO
            // 
            this.DESCRICAO_SOLUCAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRICAO_SOLUCAO.DataPropertyName = "DESCRICAO_SOLUCAO";
            this.DESCRICAO_SOLUCAO.HeaderText = "DESCRIÇÃO SOLUÇÃO";
            this.DESCRICAO_SOLUCAO.Name = "DESCRICAO_SOLUCAO";
            this.DESCRICAO_SOLUCAO.ReadOnly = true;
            this.DESCRICAO_SOLUCAO.Width = 135;
            // 
            // SETOR
            // 
            this.SETOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SETOR.DataPropertyName = "SETOR";
            this.SETOR.HeaderText = "SETOR";
            this.SETOR.Name = "SETOR";
            this.SETOR.ReadOnly = true;
            this.SETOR.Width = 69;
            // 
            // DATA_REGISTRO
            // 
            this.DATA_REGISTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATA_REGISTRO.DataPropertyName = "DATA_REGISTRO";
            this.DATA_REGISTRO.HeaderText = "DATA REGISTRO";
            this.DATA_REGISTRO.Name = "DATA_REGISTRO";
            this.DATA_REGISTRO.ReadOnly = true;
            this.DATA_REGISTRO.Width = 110;
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 76;
            // 
            // FrmExibirAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 502);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.DgvAtividades);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExibirAtividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAtividades;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ATIVIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEMA_RESOLVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_SOLUCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}