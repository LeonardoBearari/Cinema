namespace CinemaApp.Cadastros
{
    partial class CadastroSala
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
            numNumeroSala = new NumericUpDown();
            numAssentos = new NumericUpDown();
            numFileira = new NumericUpDown();
            numCapacidade = new NumericUpDown();
            lblFileira = new ReaLTaiizor.Controls.MaterialLabel();
            txtNumSala = new ReaLTaiizor.Controls.MaterialLabel();
            lblCapacidade = new ReaLTaiizor.Controls.MaterialLabel();
            lblAssentos = new ReaLTaiizor.Controls.MaterialLabel();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            TabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumeroSala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAssentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFileira).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidade).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(lblAssentos);
            tabPageCadastro.Controls.Add(lblCapacidade);
            tabPageCadastro.Controls.Add(txtNumSala);
            tabPageCadastro.Controls.Add(lblFileira);
            tabPageCadastro.Controls.Add(numCapacidade);
            tabPageCadastro.Controls.Add(numFileira);
            tabPageCadastro.Controls.Add(numAssentos);
            tabPageCadastro.Controls.Add(numNumeroSala);
            tabPageCadastro.Size = new Size(467, 306);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(numNumeroSala, 0);
            tabPageCadastro.Controls.SetChildIndex(numAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(numFileira, 0);
            tabPageCadastro.Controls.SetChildIndex(numCapacidade, 0);
            tabPageCadastro.Controls.SetChildIndex(lblFileira, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNumSala, 0);
            tabPageCadastro.Controls.SetChildIndex(lblCapacidade, 0);
            tabPageCadastro.Controls.SetChildIndex(lblAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(475, 334);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(280, 261);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(384, 261);
            // 
            // numNumeroSala
            // 
            numNumeroSala.Location = new Point(53, 91);
            numNumeroSala.Name = "numNumeroSala";
            numNumeroSala.Size = new Size(120, 23);
            numNumeroSala.TabIndex = 3;
            // 
            // numAssentos
            // 
            numAssentos.Location = new Point(249, 190);
            numAssentos.Name = "numAssentos";
            numAssentos.Size = new Size(120, 23);
            numAssentos.TabIndex = 4;
            // 
            // numFileira
            // 
            numFileira.Location = new Point(53, 190);
            numFileira.Name = "numFileira";
            numFileira.Size = new Size(120, 23);
            numFileira.TabIndex = 5;
            // 
            // numCapacidade
            // 
            numCapacidade.Location = new Point(249, 91);
            numCapacidade.Name = "numCapacidade";
            numCapacidade.Size = new Size(120, 23);
            numCapacidade.TabIndex = 6;
            // 
            // lblFileira
            // 
            lblFileira.AutoSize = true;
            lblFileira.Depth = 0;
            lblFileira.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFileira.Location = new Point(53, 168);
            lblFileira.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFileira.Name = "lblFileira";
            lblFileira.Size = new Size(44, 19);
            lblFileira.TabIndex = 7;
            lblFileira.Text = "Fileira";
            // 
            // txtNumSala
            // 
            txtNumSala.AutoSize = true;
            txtNumSala.Depth = 0;
            txtNumSala.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumSala.Location = new Point(53, 69);
            txtNumSala.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtNumSala.Name = "txtNumSala";
            txtNumSala.Size = new Size(93, 19);
            txtNumSala.TabIndex = 8;
            txtNumSala.Text = "Numero Sala";
            // 
            // lblCapacidade
            // 
            lblCapacidade.AutoSize = true;
            lblCapacidade.Depth = 0;
            lblCapacidade.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCapacidade.Location = new Point(249, 69);
            lblCapacidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCapacidade.Name = "lblCapacidade";
            lblCapacidade.Size = new Size(85, 19);
            lblCapacidade.TabIndex = 9;
            lblCapacidade.Text = "Capacidade";
            // 
            // lblAssentos
            // 
            lblAssentos.AutoSize = true;
            lblAssentos.Depth = 0;
            lblAssentos.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAssentos.Location = new Point(249, 168);
            lblAssentos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblAssentos.Name = "lblAssentos";
            lblAssentos.Size = new Size(66, 19);
            lblAssentos.TabIndex = 10;
            lblAssentos.Text = "Assentos";
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
            txtId.Location = new Point(53, 6);
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
            txtId.Size = new Size(120, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 401);
            Location = new Point(0, 0);
            Name = "CadastroSala";
            Text = "CadastroSala";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            TabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numNumeroSala).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAssentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFileira).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialLabel lblAssentos;
        private ReaLTaiizor.Controls.MaterialLabel lblCapacidade;
        private ReaLTaiizor.Controls.MaterialLabel txtNumSala;
        private ReaLTaiizor.Controls.MaterialLabel lblFileira;
        private NumericUpDown numCapacidade;
        private NumericUpDown numFileira;
        private NumericUpDown numAssentos;
        private NumericUpDown numNumeroSala;
    }
}