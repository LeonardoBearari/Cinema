namespace CinemaApp.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            buttonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            buttonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tabPageConsulta = new TabPage();
            dataGridViewConsulta = new DataGridView();
            buttonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            buttonEditar = new ReaLTaiizor.Controls.MaterialButton();
            buttonNovo = new ReaLTaiizor.Controls.MaterialButton();
            materialListView1 = new ReaLTaiizor.Controls.MaterialListView();
            imageListMenu = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageListMenu;
            TabControlCadastro.Location = new Point(3, 64);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(816, 478);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(buttonSalvar);
            tabPageCadastro.Controls.Add(buttonCancelar);
            tabPageCadastro.ImageKey = "register.png";
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(808, 450);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonSalvar.Depth = 0;
            buttonSalvar.HighEmphasis = true;
            buttonSalvar.Icon = null;
            buttonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonSalvar.Location = new Point(725, 408);
            buttonSalvar.Margin = new Padding(4, 6, 4, 6);
            buttonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.NoAccentTextColor = Color.Empty;
            buttonSalvar.Size = new Size(76, 36);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonSalvar.UseAccentColor = false;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonCancelar.Depth = 0;
            buttonCancelar.HighEmphasis = true;
            buttonCancelar.Icon = null;
            buttonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonCancelar.Location = new Point(621, 408);
            buttonCancelar.Margin = new Padding(4, 6, 4, 6);
            buttonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.NoAccentTextColor = Color.Empty;
            buttonCancelar.Size = new Size(96, 36);
            buttonCancelar.TabIndex = 0;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonCancelar.UseAccentColor = false;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(dataGridViewConsulta);
            tabPageConsulta.Controls.Add(buttonExcluir);
            tabPageConsulta.Controls.Add(buttonEditar);
            tabPageConsulta.Controls.Add(buttonNovo);
            tabPageConsulta.Controls.Add(materialListView1);
            tabPageConsulta.ImageKey = "find.png";
            tabPageConsulta.Location = new Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(808, 450);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += TabPageConsulta_Enter;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new Point(7, 6);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.ReadOnly = true;
            dataGridViewConsulta.Size = new Size(795, 393);
            dataGridViewConsulta.TabIndex = 4;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonExcluir.Depth = 0;
            buttonExcluir.HighEmphasis = true;
            buttonExcluir.Icon = null;
            buttonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonExcluir.Location = new Point(721, 405);
            buttonExcluir.Margin = new Padding(4, 6, 4, 6);
            buttonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.NoAccentTextColor = Color.Empty;
            buttonExcluir.Size = new Size(80, 36);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonExcluir.UseAccentColor = false;
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEditar.Depth = 0;
            buttonEditar.HighEmphasis = true;
            buttonEditar.Icon = null;
            buttonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonEditar.Location = new Point(642, 405);
            buttonEditar.Margin = new Padding(4, 6, 4, 6);
            buttonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonEditar.Name = "buttonEditar";
            buttonEditar.NoAccentTextColor = Color.Empty;
            buttonEditar.Size = new Size(71, 36);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEditar.UseAccentColor = false;
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonNovo.Depth = 0;
            buttonNovo.HighEmphasis = true;
            buttonNovo.Icon = null;
            buttonNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonNovo.Location = new Point(570, 405);
            buttonNovo.Margin = new Padding(4, 6, 4, 6);
            buttonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonNovo.Name = "buttonNovo";
            buttonNovo.NoAccentTextColor = Color.Empty;
            buttonNovo.Size = new Size(64, 36);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Novo";
            buttonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonNovo.UseAccentColor = false;
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.Dock = DockStyle.Top;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(3, 3);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(802, 347);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // imageListMenu
            // 
            imageListMenu.ColorDepth = ColorDepth.Depth32Bit;
            imageListMenu.ImageStream = (ImageListStreamer)resources.GetObject("imageListMenu.ImageStream");
            imageListMenu.TransparentColor = Color.Transparent;
            imageListMenu.Images.SetKeyName(0, "find.png");
            imageListMenu.Images.SetKeyName(1, "register.png");
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 545);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "CadastroBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroBase";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageConsulta;
        private ImageList imageListMenu;
        private ReaLTaiizor.Controls.MaterialButton buttonExcluir;
        private ReaLTaiizor.Controls.MaterialButton buttonEditar;
        private ReaLTaiizor.Controls.MaterialButton buttonNovo;
        private ReaLTaiizor.Controls.MaterialListView materialListView1;
        protected TabPage tabPageCadastro;
        protected ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        protected DataGridView dataGridViewConsulta;
        protected ReaLTaiizor.Controls.MaterialButton buttonCancelar;
        protected ReaLTaiizor.Controls.MaterialButton buttonSalvar;
    }
}