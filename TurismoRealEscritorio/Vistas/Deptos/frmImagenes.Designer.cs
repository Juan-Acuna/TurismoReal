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
            this.img_cargando = new System.Windows.Forms.PictureBox();
            this.btnCambiar = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_cargando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgMain.InitialImage")));
            this.imgMain.Location = new System.Drawing.Point(136, 12);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(502, 334);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMain.TabIndex = 0;
            this.imgMain.TabStop = false;
            // 
            // img1
            // 
            this.img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img1.ErrorImage")));
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.InitialImage = ((System.Drawing.Image)(resources.GetObject("img1.InitialImage")));
            this.img1.Location = new System.Drawing.Point(12, 12);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(118, 79);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 1;
            this.img1.TabStop = false;
            this.img1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img1.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // img2
            // 
            this.img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img2.ErrorImage")));
            this.img2.Image = ((System.Drawing.Image)(resources.GetObject("img2.Image")));
            this.img2.InitialImage = ((System.Drawing.Image)(resources.GetObject("img2.InitialImage")));
            this.img2.Location = new System.Drawing.Point(12, 97);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(118, 79);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 2;
            this.img2.TabStop = false;
            this.img2.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img2.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // img3
            // 
            this.img3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img3.ErrorImage")));
            this.img3.Image = ((System.Drawing.Image)(resources.GetObject("img3.Image")));
            this.img3.InitialImage = ((System.Drawing.Image)(resources.GetObject("img3.InitialImage")));
            this.img3.Location = new System.Drawing.Point(12, 182);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(118, 79);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3.TabIndex = 3;
            this.img3.TabStop = false;
            this.img3.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img3.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // img4
            // 
            this.img4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img4.ErrorImage")));
            this.img4.Image = ((System.Drawing.Image)(resources.GetObject("img4.Image")));
            this.img4.InitialImage = ((System.Drawing.Image)(resources.GetObject("img4.InitialImage")));
            this.img4.Location = new System.Drawing.Point(12, 267);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(118, 79);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img4.TabIndex = 4;
            this.img4.TabStop = false;
            this.img4.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImagenesLoad);
            this.img4.Click += new System.EventHandler(this.ImagenesClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(549, 352);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 32);
            this.btnVolver.TabIndex = 59;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // img_cargando
            // 
            this.img_cargando.Image = ((System.Drawing.Image)(resources.GetObject("img_cargando.Image")));
            this.img_cargando.Location = new System.Drawing.Point(431, 361);
            this.img_cargando.Name = "img_cargando";
            this.img_cargando.Size = new System.Drawing.Size(22, 14);
            this.img_cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_cargando.TabIndex = 61;
            this.img_cargando.TabStop = false;
            this.img_cargando.Visible = false;
            // 
            // btnCambiar
            // 
            this.btnCambiar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCambiar.ErrorImage")));
            this.btnCambiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiar.Image")));
            this.btnCambiar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCambiar.InitialImage")));
            this.btnCambiar.Location = new System.Drawing.Point(311, 300);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(58, 46);
            this.btnCambiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCambiar.TabIndex = 64;
            this.btnCambiar.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.ErrorImage")));
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.InitialImage")));
            this.btnBorrar.Location = new System.Drawing.Point(386, 300);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(58, 46);
            this.btnBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrar.TabIndex = 65;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 399);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.img_cargando);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.imgMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.img_cargando)).EndInit();
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
        private System.Windows.Forms.PictureBox img_cargando;
        private System.Windows.Forms.PictureBox btnCambiar;
        private System.Windows.Forms.PictureBox btnBorrar;
    }
}