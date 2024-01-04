namespace Sistema_Integrado_de_Vendas.Telas
{
    partial class Vendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdvProduto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCadastrar = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtPreco = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtData = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtProduto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtNomeCliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btCadastrar);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(661, 354);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Efectuar Vendas";
            // 
            // gdvProduto
            // 
            this.gdvProduto.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gdvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvProduto.BackgroundColor = System.Drawing.Color.White;
            this.gdvProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvProduto.ColumnHeadersHeight = 7;
            this.gdvProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gdvProduto.EnableHeadersVisualStyles = false;
            this.gdvProduto.GridColor = System.Drawing.Color.White;
            this.gdvProduto.Location = new System.Drawing.Point(158, 116);
            this.gdvProduto.Name = "gdvProduto";
            this.gdvProduto.ReadOnly = true;
            this.gdvProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gdvProduto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gdvProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvProduto.Size = new System.Drawing.Size(309, 140);
            this.gdvProduto.StandardTab = true;
            this.gdvProduto.TabIndex = 21;
            this.gdvProduto.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gdvProduto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvProduto.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvProduto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Purple;
            this.gdvProduto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gdvProduto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvProduto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvProduto.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gdvProduto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdvProduto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gdvProduto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvProduto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvProduto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvProduto.ThemeStyle.HeaderStyle.Height = 7;
            this.gdvProduto.ThemeStyle.ReadOnly = true;
            this.gdvProduto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvProduto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvProduto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvProduto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gdvProduto.ThemeStyle.RowsStyle.Height = 22;
            this.gdvProduto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gdvProduto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvProduto.VirtualMode = true;
            this.gdvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvProduto_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistema_Integrado_de_Vendas.Properties.Resources.icons8_buy_125px;
            this.pictureBox1.Location = new System.Drawing.Point(435, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCadastrar.BackColor = System.Drawing.Color.White;
            this.btCadastrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(10, 306);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(644, 36);
            this.btCadastrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCadastrar.Symbol = "59596";
            this.btCadastrar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "  Vender Produto";
            this.btCadastrar.TextColor = System.Drawing.Color.Purple;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gdvProduto);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.labelX8);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(10, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 261);
            this.panel1.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtQuantidade.Border.Class = "TextBoxBorder";
            this.txtQuantidade.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQuantidade.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.Purple;
            this.txtQuantidade.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtQuantidade.Location = new System.Drawing.Point(158, 172);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(248, 27);
            this.txtQuantidade.TabIndex = 27;
            this.txtQuantidade.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtQuantidade.WatermarkColor = System.Drawing.Color.Silver;
            this.txtQuantidade.WatermarkText = "Quantidade do Produto";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(15, 176);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(109, 23);
            this.labelX8.TabIndex = 26;
            this.labelX8.Text = "Quantidade:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(385, 97);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(12, 17);
            this.labelX4.Symbol = "";
            this.labelX4.SymbolColor = System.Drawing.Color.Purple;
            this.labelX4.SymbolSize = 7F;
            this.labelX4.TabIndex = 25;
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPreco.Border.Class = "TextBoxBorder";
            this.txtPreco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPreco.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.Purple;
            this.txtPreco.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPreco.Location = new System.Drawing.Point(158, 131);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(248, 27);
            this.txtPreco.TabIndex = 24;
            this.txtPreco.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtPreco.WatermarkColor = System.Drawing.Color.Silver;
            this.txtPreco.WatermarkText = "Preço do Produto";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtData.Border.Class = "TextBoxBorder";
            this.txtData.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtData.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtData.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.Purple;
            this.txtData.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtData.Location = new System.Drawing.Point(158, 51);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(248, 27);
            this.txtData.TabIndex = 24;
            this.txtData.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtData.WatermarkColor = System.Drawing.Color.Silver;
            this.txtData.WatermarkText = "Data de Venda";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(385, 94);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(12, 17);
            this.labelX6.Symbol = "";
            this.labelX6.SymbolColor = System.Drawing.Color.Purple;
            this.labelX6.SymbolSize = 7F;
            this.labelX6.TabIndex = 23;
            this.labelX6.Click += new System.EventHandler(this.labelX6_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProduto.Border.Class = "TextBoxBorder";
            this.txtProduto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProduto.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.ForeColor = System.Drawing.Color.Purple;
            this.txtProduto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtProduto.Location = new System.Drawing.Point(158, 92);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(248, 27);
            this.txtProduto.TabIndex = 22;
            this.txtProduto.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtProduto.WatermarkColor = System.Drawing.Color.Silver;
            this.txtProduto.WatermarkText = "Selecione o Produto";
            this.txtProduto.Click += new System.EventHandler(this.txtProduto_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsuario.Border.Class = "TextBoxBorder";
            this.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsuario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Purple;
            this.txtUsuario.Location = new System.Drawing.Point(158, 221);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PreventEnterBeep = true;
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(248, 27);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtUsuario.WatermarkColor = System.Drawing.Color.Silver;
            this.txtUsuario.WatermarkText = "Usuário";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(15, 221);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(137, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Nome do Usuário:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(15, 135);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Preço:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(15, 91);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Produto:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(15, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(118, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Data da Venda:";
            // 
            // txtNomeCliente
            // 
            // 
            // 
            // 
            this.txtNomeCliente.Border.Class = "TextBoxBorder";
            this.txtNomeCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNomeCliente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Purple;
            this.txtNomeCliente.Location = new System.Drawing.Point(158, 10);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.PreventEnterBeep = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(248, 27);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtNomeCliente.WatermarkColor = System.Drawing.Color.Silver;
            this.txtNomeCliente.WatermarkText = "Digite o Nome do Cliente";
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
            this.labelX1.Size = new System.Drawing.Size(137, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nome do Cliente:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.DisabledImagesGrayScale = false;
            this.buttonX2.FocusCuesEnabled = false;
            this.buttonX2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX2.Image = global::Sistema_Integrado_de_Vendas.Properties.Resources.icons8_delete_24px;
            this.buttonX2.Location = new System.Drawing.Point(642, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(36, 28);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 9;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(680, 426);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsuario;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNomeCliente;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Guna.UI2.WinForms.Guna2DataGridView gdvProduto;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProduto;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtData;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPreco;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQuantidade;
        private DevComponents.DotNetBar.LabelX labelX8;
    }
}