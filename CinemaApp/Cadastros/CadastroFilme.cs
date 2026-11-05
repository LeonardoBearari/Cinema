﻿using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;

namespace CinemaApp.Cadastros
{
    public partial class CadastroFilme : CadastroBase
    {
        private readonly IBaseService<Filme> _filmeService;
        private readonly IBaseService<Genero> _generoService;
        private List<FilmeViewModel> _filmes;
        private List<GeneroViewModel> _generos;

        public CadastroFilme(IBaseService<Filme> filmeService, IBaseService<Genero> generoService)
        {
            _filmeService = filmeService;
            _generoService = generoService;
            InitializeComponent();
            CarregaComboGeneros();
        }

        private void CarregaComboGeneros()
        {
            cboGenero.DisplayMember = nameof(GeneroViewModel.Nome);
            cboGenero.ValueMember = nameof(GeneroViewModel.Id);
            _generos = _generoService.ReadAll<GeneroViewModel>().ToList();
            cboGenero.DataSource = null;
            cboGenero.DataSource = _generos;
            cboGenero.SelectedIndex = -1;
        }

        private void PreencheObjeto(Filme filme)
        {
            filme.Nome = txtNome.Text;
            filme.Classificacao = cboClassificacao.SelectedItem?.ToString();
            filme.Genero = _generoService.ReadById<Genero>((int)cboGenero.SelectedValue);
            filme.Duracao = Convert.ToInt32(numDuracao.Value);
        }

        private void PreencheTela(Filme filme)
        {
            txtNome.Text = filme.Nome;
            cboClassificacao.SelectedItem = filme.Classificacao;
            cboGenero.SelectedItem = _generos.FirstOrDefault(g => g.Id == filme.Genero?.Id);
            numDuracao.Value = filme.Duracao;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var filme = _filmeService.ReadById<Filme>(id);
                    PreencheObjeto(filme);
                    _filmeService.Update<Filme, Filme, FilmeValidator>(filme);
                }
                else
                {
                    var filme = new Filme();
                    PreencheObjeto(filme);
                    _filmeService.Create<Filme, Filme, FilmeValidator>(filme);
                }

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
                _filmeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _filmes = _filmeService.ReadAll<FilmeViewModel>().ToList();
            dataGridViewConsulta.DataSource = _filmes;

            if (dataGridViewConsulta.Columns["Nome"] is not null)
                dataGridViewConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridViewConsulta.Columns["GeneroId"] is not null)
                dataGridViewConsulta.Columns["GeneroId"].Visible = false;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var filme = _filmeService.ReadById<Filme>(id);

            txtId.Text = filme.Id.ToString();
            PreencheTela(filme);
        }
    }
}