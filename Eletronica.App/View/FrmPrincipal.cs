using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletronica.App.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmCliente_Click(object sender, EventArgs e)
        {
            FrmListarCliente frmListaCliente = new FrmListarCliente();
            frmListaCliente.ShowDialog();
        }
    }
}
