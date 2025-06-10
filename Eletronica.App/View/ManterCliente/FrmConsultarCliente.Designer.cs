
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
            btnExcluir = new Button();
            btnEditar = new Button();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(607, 13);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(67, 23);
            btnAdicionarCliente.TabIndex = 0;
            btnAdicionarCliente.Text = "Cadastrar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 13);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(500, 23);
            txtNome.TabIndex = 1;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 42);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(776, 396);
            dgvClientes.TabIndex = 2;
            dgvClientes.TabStop = false;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 17);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(680, 13);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(51, 23);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(737, 13);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(51, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(567, 13);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(34, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(lblNome);
            Controls.Add(dgvClientes);
            Controls.Add(txtNome);
            Controls.Add(btnAdicionarCliente);
            Name = "FrmConsultarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaCliente";
            Load += FrmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Excluir;
        #endregion

        private Button btnAdicionarCliente;
        private TextBox textBox1;
        private DataGridView dgvClientes;
        private Label lblNome;
        private TextBox txtNome;
        private Button btnExcluir;
        private Button btnEditar;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button btnBuscar;
    }
}