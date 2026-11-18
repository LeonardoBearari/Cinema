
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
            var painel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                ColumnCount = assentosPorFileira,
                RowCount = fileiras,
                Padding = new Padding(15)
            };

            for (int i = 0; i < fileiras; i++)
            {
                for (int j = 0; j < assentosPorFileira; j++)
                {
                    string codigo = $"{i + 1}-{j + 1}";

                    var botao = new Button
                    {
                        Text = codigo,
                        Size = new Size(55, 45),
                        Margin = new Padding(4),
                        FlatStyle = FlatStyle.Flat,
                        Tag = codigo
                    };

                    bool ocupado = _ocupados.Contains(codigo);

                    botao.BackColor = ocupado
                        ? Color.Gray
                        : Color.LightGreen;

                    botao.Enabled = !ocupado;

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
                            botao.BackColor = Color.DodgerBlue;
                        }
                    };

                    painel.Controls.Add(botao, j, i);
                }
            }

            var confirmar = new Button
            {
                Text = "CONFIRMAR ASSENTOS",
                Dock = DockStyle.Bottom,
                Height = 45,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White
            };

            confirmar.Click += (sender, e) =>
            {
                if (_selecionados.Count == 0)
                {
                    MessageBox.Show(
                        "Selecione pelo menos um assento!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            };

            Controls.Add(painel);
            Controls.Add(confirmar);
        }
    }
}
