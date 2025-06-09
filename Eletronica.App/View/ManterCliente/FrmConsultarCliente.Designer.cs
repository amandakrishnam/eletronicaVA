
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
            txtNome.Size = new Size(715, 27);
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
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 20);
            lblNome.TabIndex = 3;
            lblNome.Text = "Consulta";
            lblNome.Text = "Nome:";
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Excluir;
        #endregion

        private Button btnAdicionarCliente;
        private TextBox textBox1;
        private DataGridView dgvClientes;
        private Label lblNome;
        private TextBox txtNome;
    }
}