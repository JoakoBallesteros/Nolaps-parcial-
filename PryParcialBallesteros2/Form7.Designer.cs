namespace PryParcialBallesteros2
{
    partial class FrmpedidoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmpedidoCliente));
            this.Pct1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LstTipo = new System.Windows.Forms.ComboBox();
            this.LstMedida = new System.Windows.Forms.ComboBox();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnHacerPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pct1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Pct1
            // 
            this.Pct1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pct1.BackgroundImage")));
            this.Pct1.Location = new System.Drawing.Point(-4, 177);
            this.Pct1.Name = "Pct1";
            this.Pct1.Size = new System.Drawing.Size(809, 97);
            this.Pct1.TabIndex = 2;
            this.Pct1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.pedidoToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 39);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem1,
            this.listaToolStripMenuItem1});
            this.clienteToolStripMenuItem1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(113, 35);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(192, 36);
            this.registroToolStripMenuItem1.Text = "Registro";
            this.registroToolStripMenuItem1.Click += new System.EventHandler(this.registroToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(192, 36);
            this.listaToolStripMenuItem1.Text = "Lista";
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fabricaToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.pedidoToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 18F);
            this.pedidoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(111, 35);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // fabricaToolStripMenuItem
            // 
            this.fabricaToolStripMenuItem.Name = "fabricaToolStripMenuItem";
            this.fabricaToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.fabricaToolStripMenuItem.Text = "Fabrica";
            this.fabricaToolStripMenuItem.Click += new System.EventHandler(this.fabricaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 18F);
            this.estadisticasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(175, 35);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 420);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LstTipo
            // 
            this.LstTipo.FormattingEnabled = true;
            this.LstTipo.Items.AddRange(new object[] {
            "Rosca Metrica",
            "Rosca Trapezoidal",
            "Rosca Whitworth",
            "Tornillo de cabeza hexagonal",
            "Tornillo de cabeza Phillips",
            "Tornillo de cabeza plana",
            "Tornillo autorroscante",
            "Tornillo para madera",
            "Tornillo de rosca métrica",
            "Tornillo de rosca trapezoidal",
            "Tornillo de rosca ACME",
            "Tornillo de rosca Whitworth",
            "Tornillo de rosca UNC (Coarse)",
            "Tornillo de rosca UNF (Fine)"});
            this.LstTipo.Location = new System.Drawing.Point(60, 116);
            this.LstTipo.Name = "LstTipo";
            this.LstTipo.Size = new System.Drawing.Size(177, 21);
            this.LstTipo.TabIndex = 11;
            // 
            // LstMedida
            // 
            this.LstMedida.FormattingEnabled = true;
            this.LstMedida.Items.AddRange(new object[] {
            "M4",
            "M5",
            "M6",
            "M8",
            "M10",
            "M12",
            "M14",
            "M16",
            "M20",
            "M24"});
            this.LstMedida.Location = new System.Drawing.Point(302, 115);
            this.LstMedida.Name = "LstMedida";
            this.LstMedida.Size = new System.Drawing.Size(170, 21);
            this.LstMedida.TabIndex = 12;
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(519, 116);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(120, 20);
            this.NudCantidad.TabIndex = 13;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(311, 324);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(171, 20);
            this.TxtNombre.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 38);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(311, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 38);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(321, 280);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 38);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // BtnHacerPedido
            // 
            this.BtnHacerPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHacerPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnHacerPedido.BackColor = System.Drawing.Color.Black;
            this.BtnHacerPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHacerPedido.BackgroundImage")));
            this.BtnHacerPedido.FlatAppearance.BorderSize = 0;
            this.BtnHacerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHacerPedido.Image = ((System.Drawing.Image)(resources.GetObject("BtnHacerPedido.Image")));
            this.BtnHacerPedido.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHacerPedido.Location = new System.Drawing.Point(247, 376);
            this.BtnHacerPedido.Name = "BtnHacerPedido";
            this.BtnHacerPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnHacerPedido.Size = new System.Drawing.Size(303, 45);
            this.BtnHacerPedido.TabIndex = 19;
            this.BtnHacerPedido.UseVisualStyleBackColor = false;
            this.BtnHacerPedido.Click += new System.EventHandler(this.BtnHacerPedido_Click);
            // 
            // FrmpedidoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHacerPedido);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.LstMedida);
            this.Controls.Add(this.LstTipo);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Pct1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmpedidoCliente";
            this.Text = "Pedido Cliente";
            this.Load += new System.EventHandler(this.FrmpedidoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pct1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pct1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox LstTipo;
        private System.Windows.Forms.ComboBox LstMedida;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnHacerPedido;
    }
}