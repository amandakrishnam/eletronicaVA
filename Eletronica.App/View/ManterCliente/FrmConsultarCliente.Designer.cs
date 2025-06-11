
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarCliente));
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
            btnAdicionarCliente.Location = new Point(652, 15);
            btnAdicionarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(84, 31);
            btnAdicionarCliente.TabIndex = 0;
            btnAdicionarCliente.Text = "Cadastrar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 17);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(537, 27);
            txtNome.TabIndex = 1;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(14, 56);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(887, 528);
            dgvClientes.TabIndex = 2;
            dgvClientes.TabStop = false;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(14, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(740, 15);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(84, 31);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(825, 15);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 31);
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
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(611, 15);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 31);
            btnBuscar.TabIndex = 6;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(lblNome);
            Controls.Add(dgvClientes);
            Controls.Add(txtNome);
            Controls.Add(btnAdicionarCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConsultarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaCliente";
            Load += FrmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnAdicionarCliente;
       // private TextBox textBox1;
        private DataGridView dgvClientes;
        private Label lblNome;
        private TextBox txtNome;
        private Button btnExcluir;
        private Button btnEditar;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button btnBuscar;
    }
}