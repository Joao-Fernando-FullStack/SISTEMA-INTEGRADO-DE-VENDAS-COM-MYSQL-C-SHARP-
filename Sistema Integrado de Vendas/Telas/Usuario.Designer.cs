namespace Sistema_Integrado_de_Vendas
{
    partial class Usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEditar = new DevComponents.DotNetBar.ButtonX();
            this.btEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btCadastrar = new DevComponents.DotNetBar.ButtonX();
            this.btSelecionarFoto = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCategoria = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtUtilizador = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtvUsuario = new System.Windows.Forms.DataGridView();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.btEliminar);
            this.groupBox1.Controls.Add(this.btCadastrar);
            this.groupBox1.Controls.Add(this.btSelecionarFoto);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(585, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Usuários";
            // 
            // btEditar
            // 
            this.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEditar.BackColor = System.Drawing.Color.White;
            this.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btEditar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(265, 243);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 32);
            this.btEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEditar.Symbol = "";
            this.btEditar.SymbolColor = System.Drawing.Color.Purple;
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.TextColor = System.Drawing.Color.Purple;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEliminar.BackColor = System.Drawing.Color.White;
            this.btEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btEliminar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(139, 243);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(106, 32);
            this.btEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEliminar.Symbol = "";
            this.btEliminar.SymbolColor = System.Drawing.Color.Red;
            this.btEliminar.TabIndex = 8;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.TextColor = System.Drawing.Color.Purple;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCadastrar.BackColor = System.Drawing.Color.White;
            this.btCadastrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btCadastrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(11, 243);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(110, 32);
            this.btCadastrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCadastrar.Symbol = "57697";
            this.btCadastrar.SymbolColor = System.Drawing.Color.Green;
            this.btCadastrar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextColor = System.Drawing.Color.Purple;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSelecionarFoto
            // 
            this.btSelecionarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSelecionarFoto.BackColor = System.Drawing.Color.White;
            this.btSelecionarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btSelecionarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelecionarFoto.FadeEffect = false;
            this.btSelecionarFoto.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelecionarFoto.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btSelecionarFoto.Location = new System.Drawing.Point(393, 241);
            this.btSelecionarFoto.Name = "btSelecionarFoto";
            this.btSelecionarFoto.Size = new System.Drawing.Size(178, 31);
            this.btSelecionarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.btSelecionarFoto.Symbol = "";
            this.btSelecionarFoto.SymbolColor = System.Drawing.Color.Green;
            this.btSelecionarFoto.TabIndex = 7;
            this.btSelecionarFoto.Text = "Selecionar Imagem";
            this.btSelecionarFoto.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btSelecionarFoto.TextColor = System.Drawing.Color.Purple;
            this.btSelecionarFoto.Click += new System.EventHandler(this.btSelecionarFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Sistema_Integrado_de_Vendas.Properties.Resources._12;
            this.pictureBox1.Location = new System.Drawing.Point(393, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.txtUtilizador);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(11, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 196);
            this.panel1.TabIndex = 0;
            // 
            // txtCategoria
            // 
            // 
            // 
            // 
            this.txtCategoria.Border.Class = "TextBoxBorder";
            this.txtCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCategoria.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.Purple;
            this.txtCategoria.Location = new System.Drawing.Point(96, 90);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PreventEnterBeep = true;
            this.txtCategoria.Size = new System.Drawing.Size(248, 92);
            this.txtCategoria.TabIndex = 5;
            this.txtCategoria.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtCategoria.WatermarkText = "Digite a Categoria";
            this.txtCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCategoria_KeyDown);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(15, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Categoria:";
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Purple;
            this.txtSenha.Location = new System.Drawing.Point(96, 51);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(248, 27);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSenha.WatermarkText = "Digite a Senha";
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(15, 51);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Senha:";
            // 
            // txtUtilizador
            // 
            // 
            // 
            // 
            this.txtUtilizador.Border.Class = "TextBoxBorder";
            this.txtUtilizador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUtilizador.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilizador.ForeColor = System.Drawing.Color.Purple;
            this.txtUtilizador.Location = new System.Drawing.Point(96, 12);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.PreventEnterBeep = true;
            this.txtUtilizador.Size = new System.Drawing.Size(248, 27);
            this.txtUtilizador.TabIndex = 1;
            this.txtUtilizador.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtUtilizador.WatermarkText = "Digite o Nome do Usuário";
            this.txtUtilizador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUtilizador_KeyDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(15, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Usuário:";
            // 
            // dtvUsuario
            // 
            this.dtvUsuario.AllowUserToAddRows = false;
            this.dtvUsuario.AllowUserToDeleteRows = false;
            this.dtvUsuario.AllowUserToResizeColumns = false;
            this.dtvUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtvUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtvUsuario.BackgroundColor = System.Drawing.Color.Purple;
            this.dtvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtvUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtvUsuario.EnableHeadersVisualStyles = false;
            this.dtvUsuario.GridColor = System.Drawing.Color.White;
            this.dtvUsuario.Location = new System.Drawing.Point(12, 331);
            this.dtvUsuario.Name = "dtvUsuario";
            this.dtvUsuario.ReadOnly = true;
            this.dtvUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtvUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtvUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvUsuario.Size = new System.Drawing.Size(586, 156);
            this.dtvUsuario.TabIndex = 1;
            this.dtvUsuario.VirtualMode = true;
            this.dtvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvUsuario_CellClick);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX5.DisabledImagesGrayScale = false;
            this.buttonX5.FocusCuesEnabled = false;
            this.buttonX5.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX5.Image = global::Sistema_Integrado_de_Vendas.Properties.Resources.icons8_delete_24px;
            this.buttonX5.Location = new System.Drawing.Point(572, 3);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(36, 28);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 4;
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(610, 498);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.dtvUsuario);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btSelecionarFoto;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCategoria;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUtilizador;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        //private DevComponents.DotNetBar.ButtonX btEditar;
        private DevComponents.DotNetBar.ButtonX btCadastrar;
        private DevComponents.DotNetBar.ButtonX btEditar;
        private DevComponents.DotNetBar.ButtonX btEliminar;
        private DevComponents.DotNetBar.ButtonX buttonX5;
    }
}