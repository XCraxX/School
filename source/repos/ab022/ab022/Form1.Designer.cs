namespace ab022
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlFeld = new System.Windows.Forms.Panel();
            this.picSpiel = new System.Windows.Forms.PictureBox();
            this.picPuk = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.vsbSpiel = new System.Windows.Forms.VScrollBar();
            this.timLauf = new System.Windows.Forms.Timer(this.components);
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.pnlFeld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuk)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFeld
            // 
            this.pnlFeld.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlFeld.Controls.Add(this.picSpiel);
            this.pnlFeld.Controls.Add(this.picPuk);
            this.pnlFeld.Location = new System.Drawing.Point(114, 35);
            this.pnlFeld.Name = "pnlFeld";
            this.pnlFeld.Size = new System.Drawing.Size(563, 302);
            this.pnlFeld.TabIndex = 0;
            // 
            // picSpiel
            // 
            this.picSpiel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picSpiel.Location = new System.Drawing.Point(556, 144);
            this.picSpiel.Name = "picSpiel";
            this.picSpiel.Size = new System.Drawing.Size(4, 40);
            this.picSpiel.TabIndex = 2;
            this.picSpiel.TabStop = false;
            // 
            // picPuk
            // 
            this.picPuk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPuk.Location = new System.Drawing.Point(28, 86);
            this.picPuk.Name = "picPuk";
            this.picPuk.Size = new System.Drawing.Size(25, 25);
            this.picPuk.TabIndex = 1;
            this.picPuk.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(217, 363);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.Location = new System.Drawing.Point(90, 363);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(44, 13);
            this.lblPunkte.TabIndex = 2;
            this.lblPunkte.Text = "Punkte:";
            // 
            // vsbSpiel
            // 
            this.vsbSpiel.Location = new System.Drawing.Point(680, 35);
            this.vsbSpiel.Name = "vsbSpiel";
            this.vsbSpiel.Size = new System.Drawing.Size(17, 302);
            this.vsbSpiel.TabIndex = 0;
            this.vsbSpiel.Value = 50;
            this.vsbSpiel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSpiel_Scroll);
            // 
            // timLauf
            // 
            this.timLauf.Tick += new System.EventHandler(this.timLauf_Tick);
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(142, 360);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(22, 20);
            this.txtPoint.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.vsbSpiel);
            this.Controls.Add(this.pnlFeld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlFeld.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSpiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFeld;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.PictureBox picPuk;
        private System.Windows.Forms.VScrollBar vsbSpiel;
        private System.Windows.Forms.PictureBox picSpiel;
        private System.Windows.Forms.Timer timLauf;
        private System.Windows.Forms.TextBox txtPoint;
    }
}

