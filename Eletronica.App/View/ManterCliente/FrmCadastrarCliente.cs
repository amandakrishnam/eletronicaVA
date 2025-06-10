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
    public partial class FrmCadastrarCliente : Form
    {
        private readonly int? _id;

        public FrmCadastrarCliente(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async Task FrmCadastrarCliente_Load(object sender, EventArgs e)
        {
            await CarregarClienteAsync();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteServices clienteServices = new ClienteServices();
            try
            {
                if (_id == null)
                {
                    await clienteServices.CadastrarAsync(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtCpfCnpj.Text, txtRG.Text, txtIE.Text);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await clienteServices.AtualizarAsync((int)_id, txtNome.Text, txtEmail.Text, txtTelefone.Text, txtCpfCnpj.Text, txtRG.Text, txtIE.Text);
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task CarregarClienteAsync()
        {
            if (_id != null)
            {
                ClienteServices clienteServices = new ClienteServices();
                ClienteEntity cliente = clienteServices.ConsultarAsync((int)_id);
                txtNome.Text = cliente.Nome;
            }
        }
    }
}
