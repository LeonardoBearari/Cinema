using CinemaApp.Cadastros;
using CinemaApp.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace CinemaApp
{
    public partial class FormPrincipal : MaterialForm
    {

        public FormPrincipal()
        {
            InitializeComponent();

            ingressoToolStripMenuItem.Click += (sender, e) =>
            {
                ExibeFormulario<CadastroIngresso>();
            };
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServiceProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir o formulário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroGenero>();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFilme>();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroSala>();
        }

        private void sessaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroSessao>();
        }


    }
}
        