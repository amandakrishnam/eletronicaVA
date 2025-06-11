namespace Eletronica.App.View
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            tsmCliente = new ToolStripMenuItem();
            tsmProduto = new ToolStripMenuItem();
            tsmUsuario = new ToolStripMenuItem();
            tsmGrupoUsuario = new ToolStripMenuItem();
            serviçoToolStripMenuItem = new ToolStripMenuItem();
            ordensDeServiçosToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, ordensDeServiçosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmCliente, tsmProduto, tsmUsuario, tsmGrupoUsuario, serviçoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tsmCliente
            // 
            tsmCliente.Name = "tsmCliente";
            tsmCliente.Size = new Size(224, 26);
            tsmCliente.Text = "Cliente";
            tsmCliente.Click += tsmCliente_Click;
            // 
            // tsmProduto
            // 
            tsmProduto.Name = "tsmProduto";
            tsmProduto.Size = new Size(224, 26);
            tsmProduto.Text = "Produto";
            // 
            // tsmUsuario
            // 
            tsmUsuario.Name = "tsmUsuario";
            tsmUsuario.Size = new Size(224, 26);
            tsmUsuario.Text = "Usuario";
            // 
            // tsmGrupoUsuario
            // 
            tsmGrupoUsuario.Name = "tsmGrupoUsuario";
            tsmGrupoUsuario.Size = new Size(224, 26);
            tsmGrupoUsuario.Text = "Grupos de usuários";
            // 
            // serviçoToolStripMenuItem
            // 
            serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            serviçoToolStripMenuItem.Size = new Size(224, 26);
            serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // ordensDeServiçosToolStripMenuItem
            // 
            ordensDeServiçosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, cadastrarToolStripMenuItem });
            ordensDeServiçosToolStripMenuItem.Name = "ordensDeServiçosToolStripMenuItem";
            ordensDeServiçosToolStripMenuItem.Size = new Size(147, 24);
            ordensDeServiçosToolStripMenuItem.Text = "Ordens de serviços";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(155, 26);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(155, 26);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eletronica V.A";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem tsmCliente;
        private ToolStripMenuItem tsmProduto;
        private ToolStripMenuItem tsmUsuario;
        private ToolStripMenuItem tsmGrupoUsuario;
        private ToolStripMenuItem serviçoToolStripMenuItem;
        private ToolStripMenuItem ordensDeServiçosToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
    }
}