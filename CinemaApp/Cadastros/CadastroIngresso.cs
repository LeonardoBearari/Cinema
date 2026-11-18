
using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using CinemaService.Validators;

namespace CinemaApp.Cadastros
{
    public partial class CadastroIngresso : CadastroBase
    {
        private readonly IBaseService<Filme>? _filmeService;
        private readonly IBaseService<Sessao>? _sessaoService;
        private readonly IBaseService<Ingresso>? _ingressoService;
        private readonly IBaseService<Sala>? _salaService;
        private readonly List<ItemIngressoTela> _itens = new();

        // Construtor utilizado pelo Designer
        public CadastroIngresso()
        {
            InitializeComponent();

            buttonSalvar.Anchor =
        AnchorStyles.Bottom | AnchorStyles.Right;

            buttonCancelar.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Right;

            buttonSalvar.Location = new Point(
                tabPageCadastro.ClientSize.Width
                    - buttonSalvar.Width - 15,
                tabPageCadastro.ClientSize.Height
                    - buttonSalvar.Height - 15
            );

            buttonCancelar.Location = new Point(
                buttonSalvar.Left - buttonCancelar.Width - 10,
                buttonSalvar.Top
            );


            ConfigurarControles();
        }


        private void AtualizaGridItens()
        {
            dgvItens.DataSource = null;
            dgvItens.DataSource = _itens.ToList();

            dgvItens.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvItens.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvItens.MultiSelect = false;
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;

            dgvItens.ReadOnly = false;

            foreach (DataGridViewColumn coluna in dgvItens.Columns)
            {
                coluna.ReadOnly = coluna.Name != "MeiaEntrada";
            }

            dgvItens.EditMode =
                DataGridViewEditMode.EditOnEnter;

            AtualizaValorTotal();
        }


        public CadastroIngresso(
            IBaseService<Filme> filmeService,
            IBaseService<Sessao> sessaoService,
            IBaseService<Ingresso> ingressoService,
            IBaseService<Sala> salaService) : this()
        {
            _filmeService = filmeService;
            _sessaoService = sessaoService;
            _ingressoService = ingressoService;
            _salaService = salaService;

            CarregaFilmes();
        }

        private void ConfigurarControles()
        {
            cboFormaPagamento.Items.Clear();

            cboFormaPagamento.Items.Add("Dinheiro");
            cboFormaPagamento.Items.Add("Pix");
            cboFormaPagamento.Items.Add("Cartão de Crédito");
            cboFormaPagamento.Items.Add("Cartão de Débito");

            cboFormaPagamento.SelectedIndex = -1;

            cboFilme.SelectedIndexChanged +=
                cboFilme_SelectedIndexChanged;

            cboSessao.SelectedIndexChanged +=
                cboSessao_SelectedIndexChanged;

            txtClassificacao.ReadOnly = true;
            txtPreco.ReadOnly = true;
            txtValorTotal.ReadOnly = true;
            txtId.ReadOnly = true;

            dgvItens.CurrentCellDirtyStateChanged += (sender, e) =>
            {
                if (dgvItens.IsCurrentCellDirty)
                {
                    dgvItens.CommitEdit(
                        DataGridViewDataErrorContexts.Commit);
                }
            };

            dgvItens.CellValueChanged += DgvItens_CellValueChanged;
        }

        private void CarregaFilmes()
        {
            if (_filmeService == null)
                return;

            var filmes = _filmeService
                .ReadAll<FilmeViewModel>()
                .ToList();

            cboFilme.DisplayMember = nameof(FilmeViewModel.Nome);
            cboFilme.ValueMember = nameof(FilmeViewModel.Id);

            cboFilme.DataSource = filmes;
            cboFilme.SelectedIndex = -1;

            cboSessao.DataSource = null;

            txtClassificacao.Clear();
            txtPreco.Clear();
        }

        private void cboFilme_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            cboSessao.DataSource = null;
            txtClassificacao.Clear();
            txtPreco.Clear();

            if (cboFilme.SelectedItem is FilmeViewModel filme)
            {
                txtClassificacao.Text = filme.Classificacao;

                CarregaSessoes(filme.Id);
            }
        }

        private void CarregaSessoes(int filmeId)
        {
            if (_sessaoService == null)
                return;

            var sessoes = _sessaoService
                .ReadAll<SessaoViewModel>()
                .Where(s => s.FilmeId == filmeId &&
                            s.Data >= DateTime.Now)
                .OrderBy(s => s.Data)
                .ToList();

            cboSessao.DisplayMember = nameof(SessaoViewModel.DataFormatada);
            cboSessao.ValueMember = nameof(SessaoViewModel.Id);

            cboSessao.DataSource = sessoes;
            cboSessao.SelectedIndex = -1;
        }

        private void cboSessao_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            _itens.Clear();
            AtualizaGridItens();
            txtPreco.Clear();

            if (cboSessao.SelectedItem is SessaoViewModel sessao)
            {
                txtPreco.Text = sessao.Preco.ToString(
                    "C2",
                    CultureInfo.GetCultureInfo("pt-BR")
                );
            }

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboSessao.SelectedItem is not SessaoViewModel sessao)
            {
                MessageBox.Show("Selecione uma sessão!");
                return;
            }

            if (_salaService == null)
            {
                MessageBox.Show("Serviço de salas não disponível!");
                return;
            }

            var sala = _salaService
                .ReadAll<SalaViewModel>()
                .FirstOrDefault(s => s.Id == sessao.SalaId);

            if (sala == null)
            {
                MessageBox.Show("Sala não encontrada!");
                return;
            }


            if (_ingressoService == null)
            {
                MessageBox.Show(
                    "Serviço de ingressos não disponível!");
                return;
            }

            var ingressosVendidos = _ingressoService
                .ReadAll<Ingresso>()
                .Where(i => i.Sessao != null &&
                            i.Sessao.Id == sessao.Id)
                .ToList();

            var assentosOcupados = ingressosVendidos
                .SelectMany(i => i.IngressoItens)
                .Select(i => $"{i.Fileira}-{i.Assento}")
                .Concat(
                    _itens.Select(i =>
                        $"{i.Fileira}-{i.Assento}")
                )
                .Distinct()
                .ToList();

            using var janela = new SelecaoAssentosForm(
                sala.Fileiras,
                sala.Assentos,
                assentosOcupados
            );

            if (janela.ShowDialog(this) == DialogResult.OK)
            {
                decimal preco = sessao.Preco;

                foreach (string codigo in janela.AssentosSelecionados)
                {
                    string[] partes = codigo.Split('-');

                    int fileira = int.Parse(partes[0]);
                    int assento = int.Parse(partes[1]);

                    bool jaExiste = _itens.Any(i =>
                        i.Fileira == fileira &&
                        i.Assento == assento);

                    if (!jaExiste)
                    {
                        _itens.Add(new ItemIngressoTela
                        {
                            Fileira = fileira,
                            Assento = assento,
                            MeiaEntrada = false,
                            Valor = preco
                        });
                    }
                }

                AtualizaGridItens();
            }

        }

        public class ItemIngressoTela
        {
            public int Fileira { get; set; }

            public int Assento { get; set; }

            public bool MeiaEntrada { get; set; }

            public decimal Valor { get; set; }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.CurrentRow?.DataBoundItem
                is ItemIngressoTela item)
            {
                _itens.Remove(item);

                AtualizaGridItens();
            }
            else
            {
                MessageBox.Show(
                    "Selecione um assento na tabela para remover!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }


        private void DgvItens_CellValueChanged(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.ColumnIndex < 0 ||
                dgvItens.Columns[e.ColumnIndex].Name != "MeiaEntrada")
            {
                return;
            }

            if (dgvItens.Rows[e.RowIndex].DataBoundItem
                is not ItemIngressoTela item)
            {
                return;
            }

            if (cboSessao.SelectedItem
                is not SessaoViewModel sessao)
            {
                return;
            }

            item.Valor = item.MeiaEntrada
                ? Math.Round(
                    sessao.Preco / 2m,
                    2,
                    MidpointRounding.AwayFromZero)
                : sessao.Preco;

            dgvItens.InvalidateRow(e.RowIndex);

            AtualizaValorTotal();
        }

        private void AtualizaValorTotal()
        {
            decimal total = _itens.Sum(i => i.Valor);

            txtValorTotal.Text = total.ToString(
                "C2",
                CultureInfo.GetCultureInfo("pt-BR")
            );
        }


        private Ingresso PreencheObjeto()
        {
            if (cboSessao.SelectedItem is not SessaoViewModel sessao)
            {
                throw new InvalidOperationException(
                    "Selecione uma sessão!");
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                throw new InvalidOperationException(
                    "Informe o documento do comprador!");
            }

            if (cboFormaPagamento.SelectedItem == null)
            {
                throw new InvalidOperationException(
                    "Selecione uma forma de pagamento!");
            }

            if (_itens.Count == 0)
            {
                throw new InvalidOperationException(
                    "Selecione pelo menos um assento!");
            }

            var ingresso = new Ingresso
            {
                Documento = txtDocumento.Text.Trim(),

                Sessao = _sessaoService!.ReadById<Sessao>(sessao.Id)
                    ?? throw new InvalidOperationException(
                        "Sessão não encontrada no banco de dados!"),

                DataCompra = DateTime.Now,

                FormaPagamento =
                    cboFormaPagamento.SelectedItem.ToString()!,

                ValorTotal = _itens.Sum(i =>
                    i.MeiaEntrada
                        ? Math.Round(
                            sessao.Preco / 2m,
                            2,
                            MidpointRounding.AwayFromZero)
                        : sessao.Preco),

                IngressoItens = new List<IngressoItem>()
            };

            foreach (var item in _itens)
            {
                ingresso.IngressoItens.Add(
                    new IngressoItem
                    {
                        Fileira = item.Fileira,
                        Assento = item.Assento,
                        MeiaEntrada = item.MeiaEntrada,
                        Ingresso = ingresso
                    });
            }

            return ingresso;
        }


        private void VerificaAssentosDisponiveis(
            int sessaoId,
            int? ingressoIgnoradoId = null)
        {
            if (_ingressoService == null)
            {
                throw new InvalidOperationException(
                    "Serviço de ingressos indisponível!");
            }

            var ingressos = _ingressoService
                .ReadAll<Ingresso>()
                .Where(i =>
                    i.Sessao != null &&
                    i.Sessao.Id == sessaoId &&
                    (!ingressoIgnoradoId.HasValue ||
                     i.Id != ingressoIgnoradoId.Value))
                .ToList();

            var ocupados = ingressos
                .SelectMany(i => i.IngressoItens)
                .Select(i => (i.Fileira, i.Assento))
                .ToHashSet();

            foreach (var item in _itens)
            {
                if (ocupados.Contains(
                    (item.Fileira, item.Assento)))
                {
                    throw new InvalidOperationException(
                        $"O assento {item.Fileira}-{item.Assento} " +
                        "já foi vendido para esta sessão!");
                }
            }
        }


        protected override void Salvar()
        {
            try
            {
                if (_ingressoService == null)
                {
                    throw new InvalidOperationException(
                        "Serviço de ingressos indisponível!");
                }

                if (IsEditMode)
                {
                    MessageBox.Show(
                        "A edição de ingressos ainda será implementada.",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                // Finaliza a edição das caixas de meia-entrada
                dgvItens.EndEdit();

                // Confere se há uma sessão selecionada
                if (cboSessao.SelectedItem
                    is not SessaoViewModel sessao)
                {
                    throw new InvalidOperationException(
                        "Selecione uma sessão!");
                }

                // Impede assentos duplicados na venda atual
                bool duplicados = _itens
                    .GroupBy(i => new { i.Fileira, i.Assento })
                    .Any(g => g.Count() > 1);

                if (duplicados)
                {
                    throw new InvalidOperationException(
                        "Existem assentos repetidos na compra!");
                }

                // Confere os lugares já vendidos
                VerificaAssentosDisponiveis(sessao.Id);

                // Constrói a entidade com seus itens
                Ingresso ingresso = PreencheObjeto();

                // Valida e salva no banco
                _ingressoService
                    .Create<Ingresso, Ingresso, IngressoValidator>(
                        ingresso);

                MessageBox.Show(
                    "Ingresso vendido com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpaCampos();

                TabControlCadastro.SelectedIndex = 1;

                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao salvar ingresso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        protected override void CarregaGrid()
        {
            if (_ingressoService == null)
                return;

            dataGridViewConsulta.DataSource = null;

            dataGridViewConsulta.DataSource = _ingressoService
                .ReadAll<IngressoViewModel>()
                .ToList();

            dataGridViewConsulta.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewConsulta.ReadOnly = true;
        }

        protected override void Deletar(int id)
        {
            try
            {
                if (_ingressoService == null)
                    throw new Exception("Serviço indisponível!");

                _ingressoService.Delete(id);

                MessageBox.Show(
                    "Ingresso excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao excluir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        protected override void Novo()
        {
            base.Novo();

            _itens.Clear();
            AtualizaGridItens();

            cboFilme.SelectedIndex = -1;
            cboSessao.DataSource = null;
            cboFormaPagamento.SelectedIndex = -1;

            txtId.Clear();
            txtDocumento.Clear();
            txtClassificacao.Clear();
            txtPreco.Clear();

            IsEditMode = false;
        }

        protected override void Editar()
        {
            MessageBox.Show(
                "A edição de ingressos ainda não foi implementada.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        protected override void LimpaCampos()
        {
            base.LimpaCampos();

            _itens.Clear();

            cboFilme.SelectedIndex = -1;
            cboSessao.DataSource = null;
            cboFormaPagamento.SelectedIndex = -1;

            txtId.Clear();
            txtDocumento.Clear();
            txtClassificacao.Clear();
            txtPreco.Clear();

            AtualizaGridItens();
        }
    }
}
