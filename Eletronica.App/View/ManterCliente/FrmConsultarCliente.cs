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
            clienteServices.ConsultarAsync("");
        }

        private async void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente frmCliente = new FrmCadastrarCliente();
            frmCliente.ShowDialog();
            await CarregarClientesAsync();
        }

        private async Task CarregarClientesAsync()
        {
            ClienteServices clienteServices = new ClienteServices();
            List<ClienteEntity> clientes = await clienteServices.ConsultarAsync(txtNome.Text);
            dgvClientes.DataSource = clientes;
            // Opcional: Ajustar automaticamente o tamanho das colunas
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private async void txtNome_TextChanged(object sender, EventArgs e)
        {
            //List<ClienteEntity> clientes = await clienteServices.ConsultarAsync(txtNome.Text); DE AGORA
            //dgvClientes.DataSource = clientes;
            await CarregarClientesAsync();
            // Opcional: Ajustar automaticamente o tamanho das colunas
            //dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a button cell and not the header
            if (e.RowIndex >= 0 && dgvClientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string columnName = dgvClientes.Columns[e.ColumnIndex].Name;
                if (columnName == "Editar")
                {
                    var clienteParaEditar = dgvClientes.Rows[e.RowIndex].DataBoundItem as ClienteEntity;
                    if (clienteParaEditar != null)
                    {
                        // Assuming FrmCliente has a constructor that takes ClienteEntity
                        FrmCadastrarCliente frmCliente = new FrmCadastrarCliente(clienteParaEditar);
                        frmCliente.ShowDialog();
                        await CarregarClientesAsync(); // Refresh data after potential edit
                    }
                }
                else if (columnName == "Excluir")
                {
                    var clienteParaDeletar = dgvClientes.Rows[e.RowIndex].DataBoundItem as ClienteEntity;
                    if (clienteParaDeletar != null)
                    {
                        var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este cliente?",
                                                             "Confirmar Exclusão",
                                                             MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            ClienteServices clienteServices = new ClienteServices();
                            await clienteServices.ExcluirAsync(clienteParaDeletar.Id);
                            await CarregarClientesAsync(); 
                        }
                    }
                }
            }
        }
    }
}
