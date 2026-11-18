
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class SelecaoAssentosForm : Form
    {
        private readonly HashSet<string> _selecionados = new();

        private readonly HashSet<string> _ocupados;

        public List<string> AssentosSelecionados =>
            _selecionados.ToList();

        public SelecaoAssentosForm(
            int fileiras,
            int assentosPorFileira,
            IEnumerable<string>? ocupados = null)
        {
            InitializeComponent();

            _ocupados = new HashSet<string>(
                ocupados ?? Enumerable.Empty<string>());

            Text = "Selecionar Assentos";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(850, 600);

            CriarMapa(fileiras, assentosPorFileira);
        }


        private void CriarMapa(int fileiras, int assentosPorFileira)
        {
            // Painel principal
            var painelPrincipal = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.FromArgb(245, 245, 245)
            };

            // Tabela com os assentos
            var tabela = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = assentosPorFileira,
                RowCount = fileiras,
                Padding = new Padding(15),
                BackColor = Color.Transparent
            };

            // Define tamanho de cada célula
            for (int i = 0; i < assentosPorFileira; i++)
                tabela.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Absolute, 58));

            for (int i = 0; i < fileiras; i++)
                tabela.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 54));

            for (int i = 0; i < fileiras; i++)
            {
                for (int j = 0; j < assentosPorFileira; j++)
                {
                    string codigo = $"{i + 1}-{j + 1}";

                    bool ocupado = _ocupados.Contains(codigo);

                    var botao = new Button
                    {
                        Text = codigo,
                        Width = 52,
                        Height = 46,
                        Margin = new Padding(3),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = ocupado
                            ? Color.LightGray
                            : Color.LightGreen,
                        Enabled = !ocupado,
                        Tag = codigo
                    };

                    botao.Click += (sender, e) =>
                    {
                        if (_selecionados.Contains(codigo))
                        {
                            _selecionados.Remove(codigo);
                            botao.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            _selecionados.Add(codigo);
                            botao.BackColor = Color.CornflowerBlue;
                        }
                    };

                    tabela.Controls.Add(botao, j, i);
                }
            }

            painelPrincipal.Controls.Add(tabela);

            // Centraliza a tabela horizontalmente
            void Centralizar()
            {
                tabela.Left = Math.Max(
                    0,
                    (painelPrincipal.ClientSize.Width
                        - tabela.Width) / 2);

                tabela.Top = 10;
            }

            painelPrincipal.Resize += (sender, e) =>
                Centralizar();

            tabela.SizeChanged += (sender, e) =>
                Centralizar();

            // Botão fixo no rodapé
            var confirmar = new Button
            {
                Text = "CONFIRMAR ASSENTOS",
                Dock = DockStyle.Bottom,
                Height = 48,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            confirmar.Click += (sender, e) =>
            {
                if (_selecionados.Count == 0)
                {
                    MessageBox.Show(
                        "Selecione pelo menos um assento!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            };

            Controls.Add(painelPrincipal);
            Controls.Add(confirmar);

            // Garante a ordem correta dos controles
            confirmar.BringToFront();

            Centralizar();
        }
    }
}
