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
    public partial class FrmConsultarCliente : Form
    {
        ClienteServices clienteServices = new ClienteServices();
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private async void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente frmCliente = new FrmCadastrarCliente();
            frmCliente.ShowDialog();
            await CarregarClientesAsync();
        }

        private async Task CarregarClientesAsync()
        {
            btnBuscar.Enabled = false;
            ClienteServices clienteServices = new ClienteServices();
            List<ClienteEntity> clientes = await clienteServices.ConsultarAsync(txtNome.Text);
            dgvClientes.DataSource = clientes;
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            btnBuscar.Enabled = true;
        }

        private async void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a button cell and not the header
            if (e.RowIndex >= 0 && dgvClientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string columnName = dgvClientes.Columns[e.ColumnIndex].Name;
                if (columnName == "Editar")
                {

                }
                else if (columnName == "Excluir")
                {

                }
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            var linha = dgvClientes.SelectedRows;

            if (linha.Count > 0)
            {
                ClienteEntity? cliente = linha[0].DataBoundItem as ClienteEntity;
                if (cliente != null)
                {
                    DialogResult resultado = MessageBox.Show($"Deja realmete excluir o cliente\n{cliente.Nome}", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        await new ClienteServices().ExcluirAsync(cliente.Id);
                        await CarregarClientesAsync();
                    }
                    return;
                }
            }
            else
                Mensagem();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
           /* var linha = dgvClientes.SelectedRows;
            if (linha.Count > 0)
            {
                ClienteEntity? cliente = linha[0].DataBoundItem as ClienteEntity;
                if (cliente != null)
                {
                    FrmCadastrarCliente frmCliente = new FrmCadastrarCliente(cliente.Id);
                    frmCliente.ShowDialog();
                    await CarregarClientesAsync();

                    // amanda
                    Update();
                    return;
                }
            }
            else
                Mensagem();*/

        }

        private void Mensagem()
        {
            MessageBox.Show("Por favor, selecione um cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await CarregarClientesAsync();
        }

        private async void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            await CarregarClientesAsync();
        }
    }
}
