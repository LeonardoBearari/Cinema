namespace CinemaApp.Cadastros
{
    partial class CadastroSessao
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
            dtpData = new DateTimePicker();
            lblData = new Label();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            numPreco = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboFilme = new ReaLTaiizor.Controls.MaterialComboBox();
            cboSala = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageCadastro.SuspendLayout();
            TabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboSala);
            tabPageCadastro.Controls.Add(cboFilme);
            tabPageCadastro.Controls.Add(numPreco);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(lblData);
            tabPageCadastro.Controls.Add(dtpData);
            tabPageCadastro.Size = new Size(659, 375);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpData, 0);
            tabPageCadastro.Controls.SetChildIndex(lblData, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(numPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFilme, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSala, 0);
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(667, 403);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(475, 333);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(579, 333);
            // 
            // dtpData
            // 
            dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.Location = new Point(311, 24);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 5;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(313, 6);
            lblData.Name = "lblData";
            lblData.Size = new Size(67, 15);
            lblData.TabIndex = 9;
            lblData.Text = "Data e hora";
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
            txtId.Location = new Point(24, 6);
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
            txtId.Size = new Size(180, 48);
            txtId.TabIndex = 7;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // numPreco
            // 
            numPreco.AllowPromptAsInput = true;
            numPreco.AnimateReadOnly = false;
            numPreco.AsciiOnly = false;
            numPreco.BackgroundImageLayout = ImageLayout.None;
            numPreco.BeepOnError = false;
            numPreco.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            numPreco.Depth = 0;
            numPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numPreco.HidePromptOnLeave = false;
            numPreco.HideSelection = true;
            numPreco.Hint = "Preço";
            numPreco.InsertKeyMode = InsertKeyMode.Default;
            numPreco.LeadingIcon = null;
            numPreco.Location = new Point(24, 184);
            numPreco.Mask = "$ 00.00";
            numPreco.MaxLength = 32767;
            numPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            numPreco.Name = "numPreco";
            numPreco.PasswordChar = '\0';
            numPreco.PrefixSuffixText = null;
            numPreco.PromptChar = '_';
            numPreco.ReadOnly = false;
            numPreco.RejectInputOnFirstFailure = false;
            numPreco.ResetOnPrompt = true;
            numPreco.ResetOnSpace = true;
            numPreco.RightToLeft = RightToLeft.No;
            numPreco.SelectedText = "";
            numPreco.SelectionLength = 0;
            numPreco.SelectionStart = 0;
            numPreco.ShortcutsEnabled = true;
            numPreco.Size = new Size(180, 48);
            numPreco.SkipLiterals = true;
            numPreco.TabIndex = 12;
            numPreco.TabStop = false;
            numPreco.Text = "R$   ,";
            numPreco.TextAlign = HorizontalAlignment.Left;
            numPreco.TextMaskFormat = MaskFormat.IncludeLiterals;
            numPreco.TrailingIcon = null;
            numPreco.UseSystemPasswordChar = false;
            numPreco.ValidatingType = null;
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
            cboFilme.Location = new Point(24, 74);
            cboFilme.MaxDropDownItems = 4;
            cboFilme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFilme.Name = "cboFilme";
            cboFilme.Size = new Size(488, 49);
            cboFilme.StartIndex = 0;
            cboFilme.TabIndex = 13;
            // 
            // cboSala
            // 
            cboSala.AutoResize = false;
            cboSala.BackColor = Color.FromArgb(255, 255, 255);
            cboSala.Depth = 0;
            cboSala.DrawMode = DrawMode.OwnerDrawVariable;
            cboSala.DropDownHeight = 174;
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.DropDownWidth = 121;
            cboSala.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSala.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSala.FormattingEnabled = true;
            cboSala.Hint = "Sala";
            cboSala.IntegralHeight = false;
            cboSala.ItemHeight = 43;
            cboSala.Location = new Point(24, 129);
            cboSala.MaxDropDownItems = 4;
            cboSala.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(487, 49);
            cboSala.StartIndex = 0;
            cboSala.TabIndex = 14;
            // 
            // CadastroSessao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 470);
            Location = new Point(0, 0);
            Name = "CadastroSessao";
            Text = "Cadastro de Sessão";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            TabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtpData;
        private Label lblData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboSala;
        private ReaLTaiizor.Controls.MaterialComboBox cboFilme;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox numPreco;
    }
}