namespace CalculadoraIMC
{
    partial class frmMuestraIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuestraIMC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOkBorrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultadoIMC = new System.Windows.Forms.TextBox();
            this.lblEstNutri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOkBorrado
            // 
            this.btnOkBorrado.BackColor = System.Drawing.Color.Red;
            this.btnOkBorrado.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOkBorrado.FlatAppearance.BorderSize = 3;
            this.btnOkBorrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOkBorrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnOkBorrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkBorrado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkBorrado.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnOkBorrado.Location = new System.Drawing.Point(325, 276);
            this.btnOkBorrado.Name = "btnOkBorrado";
            this.btnOkBorrado.Size = new System.Drawing.Size(101, 37);
            this.btnOkBorrado.TabIndex = 46;
            this.btnOkBorrado.Text = "Aceptar";
            this.btnOkBorrado.UseVisualStyleBackColor = false;
            this.btnOkBorrado.Click += new System.EventHandler(this.btnOkBorrado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 74);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tú Índice de \r\nMasa Corporal es:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // txtResultadoIMC
            // 
            this.txtResultadoIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResultadoIMC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultadoIMC.Font = new System.Drawing.Font("Franklin Gothic Heavy", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoIMC.Location = new System.Drawing.Point(296, 155);
            this.txtResultadoIMC.Name = "txtResultadoIMC";
            this.txtResultadoIMC.ReadOnly = true;
            this.txtResultadoIMC.Size = new System.Drawing.Size(191, 73);
            this.txtResultadoIMC.TabIndex = 48;
            this.txtResultadoIMC.Text = "---------";
            this.txtResultadoIMC.TextChanged += new System.EventHandler(this.txtResultadoIMC_TextChanged);
            // 
            // lblEstNutri
            // 
            this.lblEstNutri.AutoSize = true;
            this.lblEstNutri.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstNutri.Location = new System.Drawing.Point(304, 231);
            this.lblEstNutri.Name = "lblEstNutri";
            this.lblEstNutri.Size = new System.Drawing.Size(158, 26);
            this.lblEstNutri.TabIndex = 49;
            this.lblEstNutri.Text = "Estado Nutricional";
            this.lblEstNutri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMuestraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 345);
            this.ControlBox = false;
            this.Controls.Add(this.lblEstNutri);
            this.Controls.Add(this.txtResultadoIMC);
            this.Controls.Add(this.btnOkBorrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMuestraIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOkBorrado;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtResultadoIMC;
        public System.Windows.Forms.Label lblEstNutri;
    }
}