﻿namespace Gerenciador_Estagio
{
    partial class FrmCadastrarEstagiario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.TxbCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbDataInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TxbNome
            // 
            this.TxbNome.Location = new System.Drawing.Point(213, 25);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(425, 20);
            this.TxbNome.TabIndex = 1;
            // 
            // TxbCurso
            // 
            this.TxbCurso.Location = new System.Drawing.Point(213, 65);
            this.TxbCurso.Name = "TxbCurso";
            this.TxbCurso.Size = new System.Drawing.Size(425, 20);
            this.TxbCurso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso:";
            // 
            // TxbPeriodo
            // 
            this.TxbPeriodo.Location = new System.Drawing.Point(213, 112);
            this.TxbPeriodo.Name = "TxbPeriodo";
            this.TxbPeriodo.Size = new System.Drawing.Size(425, 20);
            this.TxbPeriodo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Período:";
            // 
            // TxbTelefone
            // 
            this.TxbTelefone.Location = new System.Drawing.Point(213, 161);
            this.TxbTelefone.Name = "TxbTelefone";
            this.TxbTelefone.Size = new System.Drawing.Size(201, 20);
            this.TxbTelefone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // TxbDataInicio
            // 
            this.TxbDataInicio.Location = new System.Drawing.Point(213, 207);
            this.TxbDataInicio.Name = "TxbDataInicio";
            this.TxbDataInicio.Size = new System.Drawing.Size(201, 20);
            this.TxbDataInicio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de início:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(213, 279);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 32);
            this.BtnSalvar.TabIndex = 13;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(339, 279);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 32);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmCadastrarEstagiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 373);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxbDataInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxbTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarEstagiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarEstagiario";
            this.Load += new System.EventHandler(this.FrmCadastrarEstagiario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.TextBox TxbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbDataInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}