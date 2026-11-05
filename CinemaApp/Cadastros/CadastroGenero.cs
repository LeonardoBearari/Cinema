using CinemaApp.Base;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;
using System.Configuration;

namespace CinemaApp.Cadastros
{
    public partial class CadastroGenero : CadastroBase
    {
        private IBaseService<Genero> _generoService;
        private List<Genero> _generos;
        public CadastroGenero(IBaseService<Genero> generoService)
        {
            _generoService = generoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Genero genero)
        {
           genero.Nome = txtNome.Text;
        }

        private void PreencheTela(Genero genero)
        {
            txtNome.Text = genero.Nome;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var genero = _generoService.ReadById<Genero>(id);
                    PreencheObjeto(genero);
                    _generoService.Update<Genero, Genero, GeneroValidator>(genero);
                }
                else
                {
                    var genero = new Genero();
                    PreencheObjeto(genero);
                    _generoService.Create<Genero, Genero, GeneroValidator>(genero);
                }

                IsEditMode = false;
                TabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Deletar(int id)
        {
            try
            {
                _generoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Novo()
        {
            base.Novo();
            txtId.Clear();
        }

        protected override void CarregaGrid()
        {
            _generos = _generoService.ReadAll<Genero>().ToList();
            dataGridViewConsulta.DataSource = _generos;
            dataGridViewConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtNome.Text = row.Cells["Nome"].Value.ToString();
        }
    }
}