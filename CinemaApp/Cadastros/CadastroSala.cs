using CinemaApp.Base;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class CadastroSala : CadastroBase
    {
        private readonly IBaseService<Sala> _salaService;
        private List<Sala> _salas;

        public CadastroSala(IBaseService<Sala> salaService)
        {
            _salaService = salaService;
            InitializeComponent();

            numNumeroSala.Minimum = 1;
            numCapacidade.Minimum = 1;
            numFileira.Minimum = 1;
            numAssentos.Minimum = 1;

            numCapacidade.Maximum = 1000;
            numFileira.Maximum = 100;
            numAssentos.Maximum = 100;
        }

        private void PreencheObjeto(Sala sala)
        {
            sala.Numero = Convert.ToInt32(numNumeroSala.Value);
            sala.Capacidade = Convert.ToInt32(numCapacidade.Value);
            sala.Fileiras = Convert.ToInt32(numFileira.Value);
            sala.Assentos = Convert.ToInt32(numAssentos.Value);
        }

        private void PreencheTela(Sala sala)
        {
            txtId.Text = sala.Id.ToString();
            numNumeroSala.Value = sala.Numero;
            numCapacidade.Value = sala.Capacidade;
            numFileira.Value = sala.Fileiras;
            numAssentos.Value = sala.Assentos;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var sala = _salaService.ReadById<Sala>(id);
                    PreencheObjeto(sala);
                    _salaService.Update<Sala, Sala, SalaValidator>(sala);
                }
                else
                {
                    var sala = new Sala();
                    PreencheObjeto(sala);
                    _salaService.Create<Sala, Sala, SalaValidator>(sala);
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
                _salaService.Delete(id);
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
            numNumeroSala.Value = numNumeroSala.Minimum;
            numCapacidade.Value = numCapacidade.Minimum;
            numFileira.Value = numFileira.Minimum;
            numAssentos.Value = numAssentos.Minimum;
        }

        protected override void CarregaGrid()
        {
            _salas = _salaService.ReadAll<Sala>().ToList();
            dataGridViewConsulta.DataSource = _salas;

            if (dataGridViewConsulta.Columns["Numero"] != null)
                dataGridViewConsulta.Columns["Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var sala = _salaService.ReadById<Sala>(id);
            PreencheTela(sala);
        }
    }
}
