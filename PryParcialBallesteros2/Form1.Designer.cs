namespace PryParcialBallesteros2
{
    partial class FrmSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSesion));
            this.BtnSesion = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.Pct1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSesion
            // 
            this.BtnSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSesion.BackColor = System.Drawing.Color.Black;
            this.BtnSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSesion.BackgroundImage")));
            this.BtnSesion.FlatAppearance.BorderSize = 0;
            this.BtnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSesion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSesion.Location = new System.Drawing.Point(265, 298);
            this.BtnSesion.Name = "BtnSesion";
            this.BtnSesion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSesion.Size = new System.Drawing.Size(303, 45);
            this.BtnSesion.TabIndex = 0;
            this.BtnSesion.UseVisualStyleBackColor = false;
            this.BtnSesion.Click += new System.EventHandler(this.BtnSesion_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.LblUsuario.Location = new System.Drawing.Point(174, 172);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(85, 33);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.LblContraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.LblContraseña.Location = new System.Drawing.Point(138, 216);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(121, 33);
            this.LblContraseña.TabIndex = 3;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(265, 174);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(303, 29);
            this.TxtUsuario.TabIndex = 4;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(265, 221);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(303, 29);
            this.TxtContraseña.TabIndex = 5;
            // 
            // Pct1
            // 
            this.Pct1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pct1.BackgroundImage")));
            this.Pct1.Location = new System.Drawing.Point(-4, -2);
            this.Pct1.Name = "Pct1";
            this.Pct1.Size = new System.Drawing.Size(809, 97);
            this.Pct1.TabIndex = 1;
            this.Pct1.TabStop = false;
            // 
            // FrmSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.Pct1);
            this.Controls.Add(this.BtnSesion);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSesion";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSesion;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.PictureBox Pct1;
    }
}

