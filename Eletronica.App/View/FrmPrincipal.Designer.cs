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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmCliente, tsmProduto, tsmUsuario, tsmGrupoUsuario });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tsmCliente
            // 
            tsmCliente.Name = "tsmCliente";
            tsmCliente.Size = new Size(180, 22);
            tsmCliente.Text = "Cliente";
            tsmCliente.Click += tsmCliente_Click;
            // 
            // tsmProduto
            // 
            tsmProduto.Name = "tsmProduto";
            tsmProduto.Size = new Size(180, 22);
            tsmProduto.Text = "Produto";
            // 
            // tsmUsuario
            // 
            tsmUsuario.Name = "tsmUsuario";
            tsmUsuario.Size = new Size(180, 22);
            tsmUsuario.Text = "Usuario";
            // 
            // tsmGrupoUsuario
            // 
            tsmGrupoUsuario.Name = "tsmGrupoUsuario";
            tsmGrupoUsuario.Size = new Size(180, 22);
            tsmGrupoUsuario.Text = "Grupos de usuários";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
    }
}