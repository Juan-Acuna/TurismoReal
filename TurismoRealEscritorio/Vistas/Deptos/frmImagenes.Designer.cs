namespace TurismoRealEscritorio.Vistas.Deptos
{
    partial class frmImagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImagenes));
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.PictureBox();
            this.ofdEntrada = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgMain.InitialImage")));
            this.imgMain.Location = new System.Drawing.Point(155, 12);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(592, 333);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMain.TabIndex = 0;
            this.imgMain.TabStop = false;
            // 
            // img1
            // 
            this.img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img1.ErrorImage = null;
            this.img1.InitialImage = null;
            this.img1.Location = new System.Drawing.Point(12, 12);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(128, 72);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 1;
            this.img1.TabStop = false;
            this.img1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img1.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // img2
            // 
            this.img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img2.ErrorImage = null;
            this.img2.InitialImage = null;
            this.img2.Location = new System.Drawing.Point(12, 99);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(128, 72);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 2;
            this.img2.TabStop = false;
            this.img2.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img2.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // img3
            // 
            this.img3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img3.ErrorImage = null;
            this.img3.InitialImage = null;
            this.img3.Location = new System.Drawing.Point(12, 186);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(128, 72);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3.TabIndex = 3;
            this.img3.TabStop = false;
            this.img3.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img3.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // img4
            // 
            this.img4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img4.ErrorImage = null;
            this.img4.InitialImage = null;
            this.img4.Location = new System.Drawing.Point(12, 273);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(128, 72);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img4.TabIndex = 4;
            this.img4.TabStop = false;
            this.img4.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img4.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(690, 355);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 32);
            this.btnVolver.TabIndex = 59;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.ErrorImage = null;
            this.btnCambiar.InitialImage = null;
            this.btnCambiar.Location = new System.Drawing.Point(374, 299);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(58, 46);
            this.btnCambiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCambiar.TabIndex = 64;
            this.btnCambiar.TabStop = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            this.btnCambiar.MouseEnter += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.btnCambiar.MouseLeave += new System.EventHandler(this.btnCambiar_MouseLeave);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ErrorImage = null;
            this.btnBorrar.InitialImage = null;
            this.btnBorrar.Location = new System.Drawing.Point(449, 299);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(58, 46);
            this.btnBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrar.TabIndex = 65;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            this.btnBorrar.MouseEnter += new System.EventHandler(this.btnBorrar_MouseEnter);
            this.btnBorrar.MouseLeave += new System.EventHandler(this.btnBorrar_MouseLeave);
            // 
            // ofdEntrada
            // 
            this.ofdEntrada.Filter = "Imagenes(png, jpg, jpeg, gif)|*.png;*.jpg;*.jpeg;*.gif|Todos los archivos|*.*";
            // 
            // frmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 399);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.imgMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImagenes";
            this.Load += new System.EventHandler(this.frmImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox btnCambiar;
        private System.Windows.Forms.PictureBox btnBorrar;
        private System.Windows.Forms.OpenFileDialog ofdEntrada;
    }
}