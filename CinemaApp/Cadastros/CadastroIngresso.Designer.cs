namespace CinemaApp.Cadastros
{
    partial class CadastroIngresso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtClassificacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboSessao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPreco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dgvItens = new DataGridView();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            btnRemover = new ReaLTaiizor.Controls.MaterialButton();
            txtDocumento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtValorTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboFilme = new ReaLTaiizor.Controls.MaterialComboBox();
            cboFormaPagamento = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageCadastro.SuspendLayout();
            TabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboFormaPagamento);
            tabPageCadastro.Controls.Add(txtValorTotal);
            tabPageCadastro.Controls.Add(txtDocumento);
            tabPageCadastro.Controls.Add(btnRemover);
            tabPageCadastro.Controls.Add(btnAdicionar);
            tabPageCadastro.Controls.Add(dgvItens);
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(cboSessao);
            tabPageCadastro.Controls.Add(txtClassificacao);
            tabPageCadastro.Controls.Add(cboFilme);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(841, 621);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFilme, 0);
            tabPageCadastro.Controls.SetChildIndex(txtClassificacao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSessao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(dgvItens, 0);
            tabPageCadastro.Controls.SetChildIndex(btnAdicionar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnRemover, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDocumento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValorTotal, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFormaPagamento, 0);
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(849, 649);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(753, 1092);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(857, 1092);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(569, 178);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(250, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtClassificacao
            // 
            txtClassificacao.AnimateReadOnly = false;
            txtClassificacao.AutoCompleteMode = AutoCompleteMode.None;
            txtClassificacao.AutoCompleteSource = AutoCompleteSource.None;
            txtClassificacao.BackgroundImageLayout = ImageLayout.None;
            txtClassificacao.CharacterCasing = CharacterCasing.Normal;
            txtClassificacao.Depth = 0;
            txtClassificacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClassificacao.HideSelection = true;
            txtClassificacao.Hint = "Classificação";
            txtClassificacao.LeadingIcon = null;
            txtClassificacao.Location = new Point(21, 115);
            txtClassificacao.MaxLength = 32767;
            txtClassificacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtClassificacao.Name = "txtClassificacao";
            txtClassificacao.PasswordChar = '\0';
            txtClassificacao.PrefixSuffixText = null;
            txtClassificacao.ReadOnly = true;
            txtClassificacao.RightToLeft = RightToLeft.No;
            txtClassificacao.SelectedText = "";
            txtClassificacao.SelectionLength = 0;
            txtClassificacao.SelectionStart = 0;
            txtClassificacao.ShortcutsEnabled = true;
            txtClassificacao.Size = new Size(250, 48);
            txtClassificacao.TabIndex = 15;
            txtClassificacao.TabStop = false;
            txtClassificacao.TextAlign = HorizontalAlignment.Left;
            txtClassificacao.TrailingIcon = null;
            txtClassificacao.UseSystemPasswordChar = false;
            // 
            // cboSessao
            // 
            cboSessao.AutoResize = false;
            cboSessao.BackColor = Color.FromArgb(255, 255, 255);
            cboSessao.Depth = 0;
            cboSessao.DrawMode = DrawMode.OwnerDrawVariable;
            cboSessao.DropDownHeight = 174;
            cboSessao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSessao.DropDownWidth = 121;
            cboSessao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSessao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSessao.FormattingEnabled = true;
            cboSessao.Hint = "Sessão";
            cboSessao.IntegralHeight = false;
            cboSessao.ItemHeight = 43;
            cboSessao.Location = new Point(439, 60);
            cboSessao.MaxDropDownItems = 4;
            cboSessao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSessao.Name = "cboSessao";
            cboSessao.Size = new Size(380, 49);
            cboSessao.StartIndex = 0;
            cboSessao.TabIndex = 16;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.AutoCompleteMode = AutoCompleteMode.None;
            txtPreco.AutoCompleteSource = AutoCompleteSource.None;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.CharacterCasing = CharacterCasing.Normal;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço";
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(294, 115);
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.ReadOnly = true;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(250, 48);
            txtPreco.TabIndex = 17;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Location = new Point(21, 241);
            dgvItens.MultiSelect = false;
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(798, 290);
            dgvItens.TabIndex = 18;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(21, 540);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(171, 36);
            btnAdicionar.TabIndex = 19;
            btnAdicionar.Text = " Adicionar Assento";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemover.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemover.Depth = 0;
            btnRemover.HighEmphasis = true;
            btnRemover.Icon = null;
            btnRemover.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRemover.Location = new Point(200, 540);
            btnRemover.Margin = new Padding(4, 6, 4, 6);
            btnRemover.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRemover.Name = "btnRemover";
            btnRemover.NoAccentTextColor = Color.Empty;
            btnRemover.Size = new Size(158, 36);
            btnRemover.TabIndex = 20;
            btnRemover.Text = "Remover Assento";
            btnRemover.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemover.UseAccentColor = false;
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.AnimateReadOnly = false;
            txtDocumento.AutoCompleteMode = AutoCompleteMode.None;
            txtDocumento.AutoCompleteSource = AutoCompleteSource.None;
            txtDocumento.BackgroundImageLayout = ImageLayout.None;
            txtDocumento.CharacterCasing = CharacterCasing.Normal;
            txtDocumento.Depth = 0;
            txtDocumento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocumento.HideSelection = true;
            txtDocumento.Hint = "Documento";
            txtDocumento.LeadingIcon = null;
            txtDocumento.Location = new Point(569, 115);
            txtDocumento.MaxLength = 32767;
            txtDocumento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PasswordChar = '\0';
            txtDocumento.PrefixSuffixText = null;
            txtDocumento.ReadOnly = false;
            txtDocumento.RightToLeft = RightToLeft.No;
            txtDocumento.SelectedText = "";
            txtDocumento.SelectionLength = 0;
            txtDocumento.SelectionStart = 0;
            txtDocumento.ShortcutsEnabled = true;
            txtDocumento.Size = new Size(250, 48);
            txtDocumento.TabIndex = 21;
            txtDocumento.TabStop = false;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.TrailingIcon = null;
            txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtValorTotal
            // 
            txtValorTotal.AnimateReadOnly = false;
            txtValorTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtValorTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtValorTotal.BackgroundImageLayout = ImageLayout.None;
            txtValorTotal.CharacterCasing = CharacterCasing.Normal;
            txtValorTotal.Depth = 0;
            txtValorTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorTotal.HideSelection = true;
            txtValorTotal.Hint = "Valor Total";
            txtValorTotal.LeadingIcon = null;
            txtValorTotal.Location = new Point(294, 178);
            txtValorTotal.MaxLength = 32767;
            txtValorTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.PasswordChar = '\0';
            txtValorTotal.PrefixSuffixText = null;
            txtValorTotal.ReadOnly = true;
            txtValorTotal.RightToLeft = RightToLeft.No;
            txtValorTotal.SelectedText = "";
            txtValorTotal.SelectionLength = 0;
            txtValorTotal.SelectionStart = 0;
            txtValorTotal.ShortcutsEnabled = true;
            txtValorTotal.Size = new Size(250, 48);
            txtValorTotal.TabIndex = 23;
            txtValorTotal.TabStop = false;
            txtValorTotal.TextAlign = HorizontalAlignment.Left;
            txtValorTotal.TrailingIcon = null;
            txtValorTotal.UseSystemPasswordChar = false;
            // 
            // cboFilme
            // 
            cboFilme.AutoResize = false;
            cboFilme.BackColor = Color.FromArgb(255, 255, 255);
            cboFilme.Depth = 0;
            cboFilme.DrawMode = DrawMode.OwnerDrawVariable;
            cboFilme.DropDownHeight = 174;
            cboFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilme.DropDownWidth = 121;
            cboFilme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFilme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFilme.FormattingEnabled = true;
            cboFilme.Hint = "Filme";
            cboFilme.IntegralHeight = false;
            cboFilme.ItemHeight = 43;
            cboFilme.Location = new Point(21, 60);
            cboFilme.MaxDropDownItems = 4;
            cboFilme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFilme.Name = "cboFilme";
            cboFilme.Size = new Size(396, 49);
            cboFilme.StartIndex = 0;
            cboFilme.TabIndex = 14;
            // 
            // cboFormaPagamento
            // 
            cboFormaPagamento.AutoResize = false;
            cboFormaPagamento.BackColor = Color.FromArgb(255, 255, 255);
            cboFormaPagamento.Depth = 0;
            cboFormaPagamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboFormaPagamento.DropDownHeight = 174;
            cboFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPagamento.DropDownWidth = 121;
            cboFormaPagamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFormaPagamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFormaPagamento.FormattingEnabled = true;
            cboFormaPagamento.Hint = "Forma de Pamento";
            cboFormaPagamento.IntegralHeight = false;
            cboFormaPagamento.ItemHeight = 43;
            cboFormaPagamento.Location = new Point(21, 177);
            cboFormaPagamento.MaxDropDownItems = 4;
            cboFormaPagamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFormaPagamento.Name = "cboFormaPagamento";
            cboFormaPagamento.Size = new Size(250, 49);
            cboFormaPagamento.StartIndex = 0;
            cboFormaPagamento.TabIndex = 24;
            // 
            // CadastroIngresso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 716);
            Location = new Point(0, 0);
            Name = "CadastroIngresso";
            Text = "CadastroIngresso";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            TabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClassificacao;
        private DataGridView dgvItens;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPreco;
        private ReaLTaiizor.Controls.MaterialComboBox cboSessao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDocumento;
        private ReaLTaiizor.Controls.MaterialButton btnRemover;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
        private ReaLTaiizor.Controls.MaterialComboBox cboFormaPagamento;
        private ReaLTaiizor.Controls.MaterialComboBox cboFilme;
    }
}