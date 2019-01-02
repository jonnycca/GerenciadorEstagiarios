namespace Gerenciador_Estagio
{
    partial class AdicionarEstagiarioAtividade
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
            this.ClbEstagiarios = new System.Windows.Forms.CheckedListBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClbEstagiarios
            // 
            this.ClbEstagiarios.FormattingEnabled = true;
            this.ClbEstagiarios.Location = new System.Drawing.Point(25, 22);
            this.ClbEstagiarios.Name = "ClbEstagiarios";
            this.ClbEstagiarios.Size = new System.Drawing.Size(195, 199);
            this.ClbEstagiarios.TabIndex = 0;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(69, 272);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 1;
            this.BtnAdicionar.Text = "Salvar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(183, 272);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // AdicionarEstagiarioAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 307);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.ClbEstagiarios);
            this.Name = "AdicionarEstagiarioAtividade";
            this.Text = "AdicionarEstagiarioAtividade";
            this.Load += new System.EventHandler(this.AdicionarEstagiarioAtividade_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClbEstagiarios;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}