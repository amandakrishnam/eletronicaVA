namespace Eletronica.App.View
{
    partial class FrmConsultarCliente
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
            btnAdicionarCliente = new Button();
            txtNome = new TextBox();
            dgvClientes = new DataGridView();
            lblNome = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(815, 33);
            btnAdicionarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(86, 31);
            btnAdicionarCliente.TabIndex = 0;
            btnAdicionarCliente.Text = "Cadastrar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 37);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(531, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(14, 75);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(887, 509);
            dgvClientes.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 20);
            lblNome.TabIndex = 3;
            lblNome.Text = "Consulta";
            // 
            // button1
            // 
            button1.Location = new Point(723, 33);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(631, 33);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 5;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblNome);
            Controls.Add(dgvClientes);
            Controls.Add(txtNome);
            Controls.Add(btnAdicionarCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConsultarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionarCliente;
        private TextBox textBox1;
        private DataGridView dgvClientes;
        private Label lblNome;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
    }
}