namespace Eletronica.App.View
{
    partial class FrmCliente
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCpfCnpj = new TextBox();
            txtRG = new TextBox();
            txtIE = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(192, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(192, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(192, 134);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(192, 163);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(100, 23);
            txtCpfCnpj.TabIndex = 3;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(192, 192);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(100, 23);
            txtRG.TabIndex = 4;
            // 
            // txtIE
            // 
            txtIE.Location = new Point(192, 221);
            txtIE.Name = "txtIE";
            txtIE.Size = new Size(100, 23);
            txtIE.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(217, 250);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtIE);
            Controls.Add(txtRG);
            Controls.Add(txtCpfCnpj);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpfCnpj;
        private TextBox txtRG;
        private TextBox txtIE;
        private Button btnSalvar;
    }
}