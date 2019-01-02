namespace Gerenciador_Estagio
{
    partial class FrmAdicionarAtividades
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
            this.TxbTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbDescricaoProblema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxSetor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbDescricaoSolucao = new System.Windows.Forms.TextBox();
            this.TxbDataAtividade = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxEstadoAtividade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxbTitulo
            // 
            this.TxbTitulo.Location = new System.Drawing.Point(137, 13);
            this.TxbTitulo.Name = "TxbTitulo";
            this.TxbTitulo.Size = new System.Drawing.Size(448, 20);
            this.TxbTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição do problema:";
            // 
            // TxbDescricaoProblema
            // 
            this.TxbDescricaoProblema.Location = new System.Drawing.Point(137, 59);
            this.TxbDescricaoProblema.Name = "TxbDescricaoProblema";
            this.TxbDescricaoProblema.Size = new System.Drawing.Size(448, 20);
            this.TxbDescricaoProblema.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Setor:";
            // 
            // CbxSetor
            // 
            this.CbxSetor.FormattingEnabled = true;
            this.CbxSetor.Location = new System.Drawing.Point(137, 108);
            this.CbxSetor.Name = "CbxSetor";
            this.CbxSetor.Size = new System.Drawing.Size(448, 21);
            this.CbxSetor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição solução:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data atividade:";
            // 
            // TxbDescricaoSolucao
            // 
            this.TxbDescricaoSolucao.Location = new System.Drawing.Point(137, 159);
            this.TxbDescricaoSolucao.Name = "TxbDescricaoSolucao";
            this.TxbDescricaoSolucao.Size = new System.Drawing.Size(448, 20);
            this.TxbDescricaoSolucao.TabIndex = 15;
            // 
            // TxbDataAtividade
            // 
            this.TxbDataAtividade.Location = new System.Drawing.Point(137, 213);
            this.TxbDataAtividade.Name = "TxbDataAtividade";
            this.TxbDataAtividade.Size = new System.Drawing.Size(448, 20);
            this.TxbDataAtividade.TabIndex = 16;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(137, 308);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 19;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(241, 308);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(591, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "*Obrigatório";
            // 
            // CbxEstadoAtividade
            // 
            this.CbxEstadoAtividade.FormattingEnabled = true;
            this.CbxEstadoAtividade.Location = new System.Drawing.Point(137, 255);
            this.CbxEstadoAtividade.Name = "CbxEstadoAtividade";
            this.CbxEstadoAtividade.Size = new System.Drawing.Size(448, 21);
            this.CbxEstadoAtividade.TabIndex = 18;
            // 
            // FrmAdicionarAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 478);
            this.Controls.Add(this.CbxEstadoAtividade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxbDataAtividade);
            this.Controls.Add(this.TxbDescricaoSolucao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbxSetor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbDescricaoProblema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbTitulo);
            this.Name = "FrmAdicionarAtividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar atividade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdicionarAtividades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbDescricaoProblema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxSetor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbDescricaoSolucao;
        private System.Windows.Forms.TextBox TxbDataAtividade;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxEstadoAtividade;
    }
}