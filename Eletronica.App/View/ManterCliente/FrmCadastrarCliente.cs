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
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteServices clienteServices = new ClienteServices();
            await clienteServices.CadastrarAsync(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtCpfCnpj.Text, txtRG.Text, txtIE.Text);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
