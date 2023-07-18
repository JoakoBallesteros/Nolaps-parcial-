namespace PryParcialBallesteros2
{
    partial class FrmLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLista));
            this.Pct100 = new System.Windows.Forms.PictureBox();
            this.Pct2 = new System.Windows.Forms.PictureBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Pct100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pct100
            // 
            this.Pct100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pct100.BackgroundImage")));
            this.Pct100.Location = new System.Drawing.Point(-7, 126);
            this.Pct100.Name = "Pct100";
            this.Pct100.Size = new System.Drawing.Size(814, 343);
            this.Pct100.TabIndex = 16;
            this.Pct100.TabStop = false;
            // 
            // Pct2
            // 
            this.Pct2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pct2.BackgroundImage")));
            this.Pct2.Location = new System.Drawing.Point(-7, 35);
            this.Pct2.Name = "Pct2";
            this.Pct2.Size = new System.Drawing.Size(809, 97);
            this.Pct2.TabIndex = 17;
            this.Pct2.TabStop = false;
            // 
            // DgvLista
            // 
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Location = new System.Drawing.Point(149, 167);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.Size = new System.Drawing.Size(530, 271);
            this.DgvLista.TabIndex = 18;
            this.DgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellContentClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.pedidoToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.pedidoToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 39);
            this.menuStrip2.TabIndex = 19;
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
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
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
            // pedidoToolStripMenuItem1
            // 
            this.pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            this.pedidoToolStripMenuItem1.Size = new System.Drawing.Size(56, 35);
            this.pedidoToolStripMenuItem1.Text = "Pedido";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.Pct2);
            this.Controls.Add(this.Pct100);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLista";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pct100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pct100;
        private System.Windows.Forms.PictureBox Pct2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        public System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fabricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
    }
}