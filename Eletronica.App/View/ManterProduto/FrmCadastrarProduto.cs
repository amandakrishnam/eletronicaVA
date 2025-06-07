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
    public partial class FrmCadastrarProduto : Form
    {
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }

        /* private async void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            ProdutoServices produtoServices = new ProdutoServices();
            await produtoServices.CadastrarAsync(txtNomeProduto.Text, txtTipo.Text, txtModelo.Text, txtMarca.Text, txtCategoria.Text, txtDefeito.Text);
        }*/
    }
}
