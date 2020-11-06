namespace TurismoRealEscritorio.Vistas.Deptos
{
    partial class frmVistaPrevia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaPrevia));
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesoA = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.Location = new System.Drawing.Point(12, 72);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(640, 360);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 31);
            this.label6.TabIndex = 66;
            this.label6.Text = "Vista Previa";
            // 
            // txtPesoA
            // 
            this.txtPesoA.AutoSize = true;
            this.txtPesoA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoA.Location = new System.Drawing.Point(12, 40);
            this.txtPesoA.Name = "txtPesoA";
            this.txtPesoA.Size = new System.Drawing.Size(645, 19);
            this.txtPesoA.TabIndex = 67;
            this.txtPesoA.Text = "A continuación se muestra la imagen en el tamaño máximo en el que se mostrará en " +
    "la plataforma web.";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(563, 448);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 32);
            this.btnVolver.TabIndex = 70;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 496);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtPesoA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Imagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVistaPrevia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaPrevia";
            this.Load += new System.EventHandler(this.frmVistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtPesoA;
        private System.Windows.Forms.Button btnVolver;
    }
}