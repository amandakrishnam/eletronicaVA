using Eletronica.App.Entities;
using Eletronica.App.Services;
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
    public partial class FrmListaCliente : Form
    {
        public FrmListaCliente()
        {
            InitializeComponent();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private async void txtNome_TextChanged(object sender, EventArgs e)
        {
            ClienteServices clienteServices = new ClienteServices();
            List<ClienteEntity> clientes = await clienteServices.ConsultarAsync(txtNome.Text);

            dgvClientes.DataSource = clientes;

            // Opcional: Ajustar automaticamente o tamanho das colunas
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
      
    }
}
