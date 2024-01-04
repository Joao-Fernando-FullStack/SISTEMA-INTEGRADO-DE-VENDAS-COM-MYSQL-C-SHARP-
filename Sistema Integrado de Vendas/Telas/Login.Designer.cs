namespace Sistema_Integrado_de_Vendas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbErro = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btLogin = new DevComponents.DotNetBar.ButtonX();
            this.txtUtilizador = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.lbErro);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.txtUtilizador);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 497);
            this.panel1.TabIndex = 0;
            // 
            // lbErro
            // 
            // 
            // 
            // 
            this.lbErro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbErro.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErro.ForeColor = System.Drawing.Color.White;
            this.lbErro.Location = new System.Drawing.Point(5, 447);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(379, 23);
            this.lbErro.TabIndex = 7;
            this.lbErro.Text = "Faça o Login para Acessar o Sistema";
            this.lbErro.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.White;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(191, 390);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(112, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Red;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Cancelar";
            this.buttonX1.TextColor = System.Drawing.Color.Purple;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Purple;
            // 
            // 
            // 
            this.txtSenha.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSenha.Border.BorderBottomColor = System.Drawing.Color.White;
            this.txtSenha.Border.BorderBottomWidth = 5;
            this.txtSenha.Border.BorderColor = System.Drawing.Color.Transparent;
            this.txtSenha.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSenha.Border.BorderLeftColor = System.Drawing.Color.Transparent;
            this.txtSenha.Border.BorderLeftWidth = 1;
            this.txtSenha.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSenha.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(21, 300);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(341, 37);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(23, 260);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(146, 23);
            this.labelX2.Symbol = "";
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Palavra-Passe:";
            // 
            // btLogin
            // 
            this.btLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLogin.BackColor = System.Drawing.Color.White;
            this.btLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(72, 390);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(112, 38);
            this.btLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLogin.Symbol = "";
            this.btLogin.SymbolColor = System.Drawing.Color.Green;
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.TextColor = System.Drawing.Color.Purple;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.BackColor = System.Drawing.Color.Purple;
            // 
            // 
            // 
            this.txtUtilizador.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUtilizador.Border.BorderBottomColor = System.Drawing.Color.White;
            this.txtUtilizador.Border.BorderBottomWidth = 5;
            this.txtUtilizador.Border.BorderColor = System.Drawing.Color.Transparent;
            this.txtUtilizador.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUtilizador.Border.BorderLeftColor = System.Drawing.Color.Transparent;
            this.txtUtilizador.Border.BorderLeftWidth = 1;
            this.txtUtilizador.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUtilizador.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUtilizador.Border.Class = "TextBoxBorder";
            this.txtUtilizador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUtilizador.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilizador.ForeColor = System.Drawing.Color.White;
            this.txtUtilizador.Location = new System.Drawing.Point(21, 202);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.PreventEnterBeep = true;
            this.txtUtilizador.Size = new System.Drawing.Size(341, 34);
            this.txtUtilizador.TabIndex = 2;
            this.txtUtilizador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUtilizador_KeyDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(23, 160);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 23);
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Utilizador:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Integrado_de_Vendas.Properties.Resources.Lock_96phx;
            this.pictureBox1.Location = new System.Drawing.Point(129, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUtilizador;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX lbErro;
    }
}