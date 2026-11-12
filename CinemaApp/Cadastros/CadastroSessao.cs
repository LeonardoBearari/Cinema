using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class CadastroSessao : CadastroBase
    {
        private readonly IBaseService<Sessao> _sessaoService;
        private readonly IBaseService<Filme> _filmeService;
        private readonly IBaseService<Sala> _salaService;
        private List<SessaoViewModel> _sessoes;
        public CadastroSessao(IBaseService<Sessao> sessaoService,
            IBaseService<Filme> filmeService, IBaseService<Sala> salaService)
        {
            _sessaoService = sessaoService;
            _filmeService = filmeService;
            _salaService = salaService;
            InitializeComponent();
            CarregaCombos();
        }

        private void CarregaCombos()
        {
            var filmes = _filmeService.ReadAll<FilmeViewModel>().ToList();
            cboFilme.DisplayMember = nameof(FilmeViewModel.Nome);
            cboFilme.ValueMember = nameof(FilmeViewModel.Id);
            cboFilme.DataSource = filmes;
            cboFilme.SelectedIndex = -1;

            var salas = _salaService.ReadAll<Sala>().ToList();
            cboSala.DisplayMember = nameof(Sala.Numero);
            cboSala.ValueMember = nameof(Sala.Id);
            cboSala.DataSource = salas;
            cboSala.SelectedIndex = -1;
        }

        private void PreencheObjeto(Sessao sessao)
        {
            if (cboFilme.SelectedValue == null || cboSala.SelectedValue == null)
                throw new InvalidOperationException("Filme e sala devem ser informados.");

            sessao.Filme = _filmeService.ReadById<Filme>(Convert.ToInt32(cboFilme.SelectedValue));
            sessao.Sala = _salaService.ReadById<Sala>(Convert.ToInt32(cboSala.SelectedValue));
            sessao.Data = dtpData.Value;
            sessao.Preco = ObterPreco();
        }

        private decimal ObterPreco()
        {
            string numeros = new string(
                numPreco.Text.Where(char.IsDigit).ToArray()
            );

            if (string.IsNullOrEmpty(numeros))
            {
                throw new InvalidOperationException(
                    "Preço deve ser informado!");
            }

            decimal preco = decimal.Parse(
                numeros,
                CultureInfo.InvariantCulture
            ) / 100m;

            return preco;
        }

        private void PreencheTela(Sessao sessao)
        {
            txtId.Text = sessao.Id.ToString();
            dtpData.Value = sessao.Data;
            numPreco.Text = sessao.Preco.ToString("N2", CultureInfo.CurrentCulture);
            cboFilme.SelectedValue = sessao.Filme?.Id ?? -1;
            cboSala.SelectedValue = sessao.Sala?.Id ?? -1;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var sessao = _sessaoService.ReadById<Sessao>(id);
                    PreencheObjeto(sessao);
                    _sessaoService.Update<Sessao, Sessao, SessaoValidator>(sessao);
                }
                else
                {
                    var sessao = new Sessao();
                    PreencheObjeto(sessao);
                    _sessaoService.Create<Sessao, Sessao, SessaoValidator>(sessao);
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
                _sessaoService.Delete(id);
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
            cboFilme.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
            dtpData.Value = DateTime.Now.AddMinutes(1);
            numPreco.Clear();
        }


        protected override void CarregaGrid()
        {
            _sessoes = _sessaoService
                .ReadAll<SessaoViewModel>()
                .ToList();

            dataGridViewConsulta.DataSource = _sessoes;

            if (dataGridViewConsulta.Columns["FilmeNome"] != null)
            {
                dataGridViewConsulta.Columns["FilmeNome"]
                    .AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dataGridViewConsulta.Columns["FilmeId"] != null)
                dataGridViewConsulta.Columns["FilmeId"].Visible = false;

            if (dataGridViewConsulta.Columns["SalaId"] != null)
                dataGridViewConsulta.Columns["SalaId"].Visible = false;
        }


        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var sessao = _sessaoService.ReadById<Sessao>(id);
            PreencheTela(sessao);
        }
    }
}
