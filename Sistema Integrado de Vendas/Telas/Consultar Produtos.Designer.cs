namespace Sistema_Integrado_de_Vendas.Telas
{
    partial class Consultar_Produtos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Produtos));
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtPesquisar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btEditar = new DevComponents.DotNetBar.ButtonX();
            this.btImprimir = new DevComponents.DotNetBar.ButtonX();
            this.dtvProduto = new System.Windows.Forms.DataGridView();
            this.lbTotal = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.White;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(584, 29);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.buttonX1.Size = new System.Drawing.Size(107, 27);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Purple;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "Pesquisar";
            this.buttonX1.TextColor = System.Drawing.Color.Purple;
            this.buttonX1.ThemeAware = true;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtPesquisar
            // 
            // 
            // 
            // 
            this.txtPesquisar.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.txtPesquisar.Border.BorderLightGradientAngle = 0;
            this.txtPesquisar.Border.Class = "TextBoxBorder";
            this.txtPesquisar.Border.CornerDiameter = 0;
            this.txtPesquisar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPesquisar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Purple;
            this.txtPesquisar.Location = new System.Drawing.Point(692, 29);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PreventEnterBeep = true;
            this.txtPesquisar.Size = new System.Drawing.Size(282, 27);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtPesquisar.WatermarkColor = System.Drawing.Color.Silver;
            this.txtPesquisar.WatermarkText = "Pesquise Aqui";
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.btImprimir);
            this.groupBox1.Controls.Add(this.dtvProduto);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(963, 526);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Produtos";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.ImageTextSpacing = 7;
            this.buttonX2.Location = new System.Drawing.Point(869, 315);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.buttonX2.Size = new System.Drawing.Size(76, 100);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.White;
            this.buttonX2.SymbolSize = 40F;
            this.buttonX2.TabIndex = 9;
            this.buttonX2.Text = "Menu";
            this.buttonX2.TextColor = System.Drawing.Color.White;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btEditar
            // 
            this.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEditar.BackColor = System.Drawing.Color.Transparent;
            this.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btEditar.ImageTextSpacing = 7;
            this.btEditar.Location = new System.Drawing.Point(793, 316);
            this.btEditar.Name = "btEditar";
            this.btEditar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.btEditar.Size = new System.Drawing.Size(76, 100);
            this.btEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEditar.Symbol = "";
            this.btEditar.SymbolColor = System.Drawing.Color.White;
            this.btEditar.SymbolSize = 40F;
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "Editar";
            this.btEditar.TextColor = System.Drawing.Color.White;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImprimir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btImprimir.Location = new System.Drawing.Point(711, 316);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.btImprimir.Size = new System.Drawing.Size(79, 100);
            this.btImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btImprimir.Symbol = "58709";
            this.btImprimir.SymbolColor = System.Drawing.Color.White;
            this.btImprimir.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btImprimir.SymbolSize = 50F;
            this.btImprimir.TabIndex = 6;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.TextColor = System.Drawing.Color.White;
            this.btImprimir.ThemeAware = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // dtvProduto
            // 
            this.dtvProduto.AllowUserToAddRows = false;
            this.dtvProduto.AllowUserToDeleteRows = false;
            this.dtvProduto.AllowUserToResizeColumns = false;
            this.dtvProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvProduto.BackgroundColor = System.Drawing.Color.Purple;
            this.dtvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtvProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtvProduto.EnableHeadersVisualStyles = false;
            this.dtvProduto.GridColor = System.Drawing.Color.White;
            this.dtvProduto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtvProduto.Location = new System.Drawing.Point(7, 33);
            this.dtvProduto.Name = "dtvProduto";
            this.dtvProduto.ReadOnly = true;
            this.dtvProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtvProduto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtvProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvProduto.Size = new System.Drawing.Size(698, 486);
            this.dtvProduto.TabIndex = 7;
            this.dtvProduto.VirtualMode = true;
            this.dtvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvProduto_CellClick);
            // 
            // lbTotal
            // 
            // 
            // 
            // 
            this.lbTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTotal.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(849, 496);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(66, 23);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "...";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(711, 496);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(132, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Total de Produtos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Sistema_Integrado_de_Vendas.Properties.Resources.icons8_trolley_125px;
            this.pictureBox1.Location = new System.Drawing.Point(711, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX3.DisabledImagesGrayScale = false;
            this.buttonX3.FocusCuesEnabled = false;
            this.buttonX3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX3.Image = global::Sistema_Integrado_de_Vendas.Properties.Resources.icons8_delete_24px;
            this.buttonX3.Location = new System.Drawing.Point(949, 0);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(36, 28);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 10;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Relatório dos Produtos";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Consultar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(984, 595);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultar_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_Produtos";
            this.Load += new System.EventHandler(this.Consultar_Produtos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btEditar;
        private DevComponents.DotNetBar.ButtonX btImprimir;
        private System.Windows.Forms.DataGridView dtvProduto;
        private DevComponents.DotNetBar.LabelX lbTotal;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}