namespace PryParcialBallesteros2
{
    partial class FrmEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadistica));
            this.ChartVenta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartProduccion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartGasto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnDia = new System.Windows.Forms.Button();
            this.BtnSemana = new System.Windows.Forms.Button();
            this.BtnMes = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartGasto)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartVenta
            // 
            chartArea16.Name = "ChartArea1";
            this.ChartVenta.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.ChartVenta.Legends.Add(legend16);
            this.ChartVenta.Location = new System.Drawing.Point(12, 70);
            this.ChartVenta.Name = "ChartVenta";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Ventas";
            this.ChartVenta.Series.Add(series16);
            this.ChartVenta.Size = new System.Drawing.Size(256, 300);
            this.ChartVenta.TabIndex = 0;
            this.ChartVenta.Text = "Ventas";
            // 
            // ChartProduccion
            // 
            chartArea17.Name = "ChartArea1";
            this.ChartProduccion.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.ChartProduccion.Legends.Add(legend17);
            this.ChartProduccion.Location = new System.Drawing.Point(274, 70);
            this.ChartProduccion.Name = "ChartProduccion";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Produccion";
            this.ChartProduccion.Series.Add(series17);
            this.ChartProduccion.Size = new System.Drawing.Size(300, 300);
            this.ChartProduccion.TabIndex = 1;
            this.ChartProduccion.Text = "Produccion";
            // 
            // ChartGasto
            // 
            chartArea18.Name = "ChartArea1";
            this.ChartGasto.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.ChartGasto.Legends.Add(legend18);
            this.ChartGasto.Location = new System.Drawing.Point(580, 70);
            this.ChartGasto.Name = "ChartGasto";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Gastos";
            this.ChartGasto.Series.Add(series18);
            this.ChartGasto.Size = new System.Drawing.Size(247, 300);
            this.ChartGasto.TabIndex = 2;
            this.ChartGasto.Text = "Ventas";
            // 
            // BtnDia
            // 
            this.BtnDia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDia.BackgroundImage")));
            this.BtnDia.Location = new System.Drawing.Point(72, 395);
            this.BtnDia.Name = "BtnDia";
            this.BtnDia.Size = new System.Drawing.Size(159, 45);
            this.BtnDia.TabIndex = 3;
            this.BtnDia.UseVisualStyleBackColor = true;
            this.BtnDia.Click += new System.EventHandler(this.BtnDia_Click);
            // 
            // BtnSemana
            // 
            this.BtnSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSemana.BackgroundImage")));
            this.BtnSemana.Location = new System.Drawing.Point(326, 395);
            this.BtnSemana.Name = "BtnSemana";
            this.BtnSemana.Size = new System.Drawing.Size(159, 45);
            this.BtnSemana.TabIndex = 4;
            this.BtnSemana.UseVisualStyleBackColor = true;
            this.BtnSemana.Click += new System.EventHandler(this.BtnSemana_Click);
            // 
            // BtnMes
            // 
            this.BtnMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMes.BackgroundImage")));
            this.BtnMes.Location = new System.Drawing.Point(580, 395);
            this.BtnMes.Name = "BtnMes";
            this.BtnMes.Size = new System.Drawing.Size(159, 45);
            this.BtnMes.TabIndex = 5;
            this.BtnMes.UseVisualStyleBackColor = true;
            this.BtnMes.Click += new System.EventHandler(this.BtnMes_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.pedidoToolStripMenuItem,
            this.estadisticaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(832, 39);
            this.menuStrip2.TabIndex = 17;
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
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fabrToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.pedidoToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 18F);
            this.pedidoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(111, 35);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // fabrToolStripMenuItem
            // 
            this.fabrToolStripMenuItem.Name = "fabrToolStripMenuItem";
            this.fabrToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.fabrToolStripMenuItem.Text = "Fabrica";
            this.fabrToolStripMenuItem.Click += new System.EventHandler(this.fabrToolStripMenuItem_Click);
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
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 18F);
            this.estadisticaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(163, 35);
            this.estadisticaToolStripMenuItem.Text = "Estadistica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-27, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 411);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(832, 452);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.BtnMes);
            this.Controls.Add(this.BtnSemana);
            this.Controls.Add(this.BtnDia);
            this.Controls.Add(this.ChartGasto);
            this.Controls.Add(this.ChartProduccion);
            this.Controls.Add(this.ChartVenta);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadistica";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartGasto)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVenta;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProduccion;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartGasto;
        private System.Windows.Forms.Button BtnDia;
        private System.Windows.Forms.Button BtnSemana;
        private System.Windows.Forms.Button BtnMes;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}