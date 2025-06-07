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
            lblNome = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblCpfCnpj = new Label();
            lblRG = new Label();
            lblIE = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(219, 101);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(560, 27);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 140);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(560, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(219, 179);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(204, 27);
            txtTelefone.TabIndex = 2;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(219, 217);
            txtCpfCnpj.Margin = new Padding(3, 4, 3, 4);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(204, 27);
            txtCpfCnpj.TabIndex = 3;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(571, 179);
            txtRG.Margin = new Padding(3, 4, 3, 4);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(208, 27);
            txtRG.TabIndex = 4;
            // 
            // txtIE
            // 
            txtIE.Location = new Point(571, 220);
            txtIE.Margin = new Padding(3, 4, 3, 4);
            txtIE.Name = "txtIE";
            txtIE.Size = new Size(208, 27);
            txtIE.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(459, 495);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 31);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(152, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(152, 147);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(138, 182);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(134, 220);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(79, 20);
            lblCpfCnpj.TabIndex = 10;
            lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Location = new Point(517, 186);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(28, 20);
            lblRG.TabIndex = 11;
            lblRG.Text = "RG";
            // 
            // lblIE
            // 
            lblIE.AutoSize = true;
            lblIE.Location = new Point(517, 224);
            lblIE.Name = "lblIE";
            lblIE.Size = new Size(21, 20);
            lblIE.TabIndex = 12;
            lblIE.Text = "IE";
            // 
            // button1
            // 
            button1.Location = new Point(346, 497);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(lblIE);
            Controls.Add(lblRG);
            Controls.Add(lblCpfCnpj);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(txtIE);
            Controls.Add(txtRG);
            Controls.Add(txtCpfCnpj);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
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
        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblCpfCnpj;
        private Label lblRG;
        private Label lblIE;
        private Button button1;
    }
}