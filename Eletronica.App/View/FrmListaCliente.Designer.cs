namespace Eletronica.App.View
{
    partial class FrmListaCliente
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(713, 22);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(75, 23);
            btnAdicionarCliente.TabIndex = 0;
            btnAdicionarCliente.Text = "button1";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(63, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(572, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 56);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(776, 382);
            dgvClientes.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(19, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "label1";
            // 
            // FrmListaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNome);
            Controls.Add(dgvClientes);
            Controls.Add(txtNome);
            Controls.Add(btnAdicionarCliente);
            Name = "FrmListaCliente";
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
    }
}