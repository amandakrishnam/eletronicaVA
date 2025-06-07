namespace Eletronica.App.View
{
    partial class FrmCadastrarProduto
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
            txtCategoria = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtTipo = new TextBox();
            txtDefeito = new TextBox();
            txtNomeProduto = new TextBox();
            lblTipo = new Label();
            lblCategoria = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblDefeito = new Label();
            lblNomeProduto = new Label();
            BtnSalvarProduto = new Button();
            btnVoltarProduto = new Button();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(639, 279);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(200, 27);
            txtCategoria.TabIndex = 52;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(639, 229);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(200, 27);
            txtModelo.TabIndex = 51;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(239, 279);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(200, 27);
            txtMarca.TabIndex = 50;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(239, 229);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(200, 27);
            txtTipo.TabIndex = 49;
            // 
            // txtDefeito
            // 
            txtDefeito.Location = new Point(239, 329);
            txtDefeito.Name = "txtDefeito";
            txtDefeito.Size = new Size(600, 27);
            txtDefeito.TabIndex = 48;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(239, 176);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(600, 27);
            txtNomeProduto.TabIndex = 47;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F);
            lblTipo.Location = new Point(99, 229);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 23);
            lblTipo.TabIndex = 46;
            lblTipo.Text = "Tipo";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F);
            lblCategoria.Location = new Point(549, 279);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 23);
            lblCategoria.TabIndex = 45;
            lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F);
            lblMarca.Location = new Point(99, 279);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(57, 23);
            lblMarca.TabIndex = 44;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 10F);
            lblModelo.Location = new Point(549, 229);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(68, 23);
            lblModelo.TabIndex = 43;
            lblModelo.Text = "Modelo";
            // 
            // lblDefeito
            // 
            lblDefeito.AutoSize = true;
            lblDefeito.Font = new Font("Segoe UI", 10F);
            lblDefeito.Location = new Point(99, 329);
            lblDefeito.Name = "lblDefeito";
            lblDefeito.Size = new Size(65, 23);
            lblDefeito.TabIndex = 42;
            lblDefeito.Text = "Defeito";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Segoe UI", 10F);
            lblNomeProduto.Location = new Point(99, 179);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(72, 23);
            lblNomeProduto.TabIndex = 41;
            lblNomeProduto.Text = "Produto";
            // 
            // BtnSalvarProduto
            // 
            BtnSalvarProduto.Font = new Font("Segoe UI", 10F);
            BtnSalvarProduto.Location = new Point(739, 475);
            BtnSalvarProduto.Name = "BtnSalvarProduto";
            BtnSalvarProduto.Size = new Size(100, 35);
            BtnSalvarProduto.TabIndex = 40;
            BtnSalvarProduto.Text = "Salvar";
            BtnSalvarProduto.UseVisualStyleBackColor = true;
            //BtnSalvarProduto.Click += btnSalvarProduto_Click;
            // 
            // btnVoltarProduto
            // 
            btnVoltarProduto.Font = new Font("Segoe UI", 10F);
            btnVoltarProduto.Location = new Point(633, 475);
            btnVoltarProduto.Name = "btnVoltarProduto";
            btnVoltarProduto.Size = new Size(100, 35);
            btnVoltarProduto.TabIndex = 39;
            btnVoltarProduto.Text = "Voltar";
            btnVoltarProduto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(367, 38);
            label4.Name = "label4";
            label4.Size = new Size(207, 28);
            label4.TabIndex = 38;
            label4.Text = "Cadastro do Produto";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(99, 116);
            label2.Name = "label2";
            label2.Size = new Size(241, 28);
            label2.TabIndex = 36;
            label2.Text = "Informações do Produto";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 548);
            Controls.Add(txtCategoria);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtTipo);
            Controls.Add(txtDefeito);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblTipo);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lblModelo);
            Controls.Add(lblDefeito);
            Controls.Add(lblNomeProduto);
            Controls.Add(BtnSalvarProduto);
            Controls.Add(btnVoltarProduto);
            Controls.Add(label4);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "FrmProduto";
            Text = "FrmProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoria;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtTipo;
        private TextBox txtDefeito;
        private TextBox txtNomeProduto;
        private Label lblTipo;
        private Label lblCategoria;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblDefeito;
        private Label lblNomeProduto;
        private Button BtnSalvarProduto;
        private Button btnVoltarProduto;
        private Label label4;
        private Label label2;
    }
}