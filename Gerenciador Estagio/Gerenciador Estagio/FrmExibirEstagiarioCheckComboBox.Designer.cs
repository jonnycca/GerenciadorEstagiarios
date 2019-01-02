namespace Gerenciador_Estagio
{
    partial class FrmExibirEstagiarioCheckComboBox
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClbEstagiarios
            // 
            this.ClbEstagiarios.FormattingEnabled = true;
            this.ClbEstagiarios.Location = new System.Drawing.Point(23, 12);
            this.ClbEstagiarios.Name = "ClbEstagiarios";
            this.ClbEstagiarios.Size = new System.Drawing.Size(408, 274);
            this.ClbEstagiarios.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(23, 308);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmExibirEstagiarioCheckComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 347);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.ClbEstagiarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExibirEstagiarioCheckComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estagiarios";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox ClbEstagiarios;
        private System.Windows.Forms.Button BtnOk;
    }
}