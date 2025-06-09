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
        private ClienteEntity _clienteAtual;
        public FrmCadastrarCliente()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmCadastrarCliente_Load);
        }

       
        public FrmCadastrarCliente(ClienteEntity cliente) : this()
        {
            _clienteAtual = cliente;
        }

        private void FrmCadastrarCliente_Load(object sender, EventArgs e)
        {
            if (_clienteAtual != null)
            {
                txtNome.Text = _clienteAtual.Nome;
                txtEmail.Text = _clienteAtual.Email;
                txtTelefone.Text = _clienteAtual.Telefone;
                txtCpfCnpj.Text = _clienteAtual.CnpjCpf;
                txtRG.Text = _clienteAtual.RG;
                txtIE.Text = _clienteAtual.IE ?? string.Empty; // IE pode ser nulo
                this.Text = "Atualizar Cliente";
            }
            else
            {
                this.Text = "Cadastrar Cliente";
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteServices clienteServices = new ClienteServices();
            try
            {
                if (_clienteAtual == null)
                {
                    await clienteServices.CadastrarAsync(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtCpfCnpj.Text, txtRG.Text, txtIE.Text);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // edit mode
                {
                    _clienteAtual.Nome = txtNome.Text;
                    _clienteAtual.Email = txtEmail.Text;
                    _clienteAtual.Telefone = txtTelefone.Text;
                    _clienteAtual.CnpjCpf = txtCpfCnpj.Text;
                    _clienteAtual.RG = txtRG.Text;
                    _clienteAtual.IE = txtIE.Text;

                    await clienteServices.AtualizarAsync(_clienteAtual.Nome, _clienteAtual.Email, _clienteAtual.Telefone, _clienteAtual.CnpjCpf, _clienteAtual.RG, _clienteAtual.IE);
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
    }
}
