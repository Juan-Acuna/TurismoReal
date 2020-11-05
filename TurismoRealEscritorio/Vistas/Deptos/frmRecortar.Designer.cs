namespace TurismoRealEscritorio.Vistas.Deptos
{
    partial class frmRecortar
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
            this.btnRecortar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.txtPesoA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pBase = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.pBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecortar
            // 
            this.btnRecortar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecortar.Location = new System.Drawing.Point(525, 451);
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(125, 32);
            this.btnRecortar.TabIndex = 70;
            this.btnRecortar.Text = "Recortar Imagen";
            this.btnRecortar.UseVisualStyleBackColor = true;
            this.btnRecortar.Click += new System.EventHandler(this.btnRecortar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(421, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // imgMain
            // 
            this.imgMain.Location = new System.Drawing.Point(0, 0);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(640, 360);
            this.imgMain.TabIndex = 71;
            this.imgMain.TabStop = false;
            this.imgMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.imgMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.imgMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // txtPesoA
            // 
            this.txtPesoA.AutoSize = true;
            this.txtPesoA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoA.Location = new System.Drawing.Point(6, 40);
            this.txtPesoA.Name = "txtPesoA";
            this.txtPesoA.Size = new System.Drawing.Size(516, 19);
            this.txtPesoA.TabIndex = 73;
            this.txtPesoA.Text = "Arrastre la imagen con el cursor hasta que el área que desea conservar este visib" +
    "le.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 31);
            this.label6.TabIndex = 72;
            this.label6.Text = "Vista Previa";
            // 
            // pBase
            // 
            this.pBase.Controls.Add(this.imgMain);
            this.pBase.Location = new System.Drawing.Point(10, 71);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(640, 360);
            this.pBase.TabIndex = 74;
            // 
            // frmRecortar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 504);
            this.ControlBox = false;
            this.Controls.Add(this.pBase);
            this.Controls.Add(this.txtPesoA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRecortar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmRecortar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecortar";
            this.Load += new System.EventHandler(this.frmRecortar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.pBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.Label txtPesoA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pBase;
    }
}