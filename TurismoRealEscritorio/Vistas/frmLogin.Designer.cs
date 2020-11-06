namespace TurismoRealEscritorio
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbError = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.LinkLabel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.pbRandom = new System.Windows.Forms.PictureBox();
            this.pReconectando = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerConexion = new System.Windows.Forms.Timer(this.components);
            this.lbLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRandom)).BeginInit();
            this.pReconectando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbError.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(375, 218);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(142, 17);
            this.lbError.TabIndex = 99;
            this.lbError.Text = "     {Mensaje de error}";
            this.lbError.TextChanged += new System.EventHandler(this.lbError_TextChanged);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.AutoSize = true;
            this.btnRecuperar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.LinkColor = System.Drawing.Color.White;
            this.btnRecuperar.Location = new System.Drawing.Point(385, 278);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(122, 16);
            this.btnRecuperar.TabIndex = 10;
            this.btnRecuperar.TabStop = true;
            this.btnRecuperar.Text = "Recuperar contraseña";
            this.btnRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRecuperar_LinkClicked);
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(305, 240);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(283, 35);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Login";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.btnIniciar.MouseEnter += new System.EventHandler(this.btnIniciar_MouseEnter);
            this.btnIniciar.MouseLeave += new System.EventHandler(this.btnIniciar_MouseLeave);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(305, 187);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(283, 28);
            this.txtClave.TabIndex = 1;
            this.txtClave.Click += new System.EventHandler(this.txtClave_Click);
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbClave.Location = new System.Drawing.Point(309, 191);
            this.lbClave.Margin = new System.Windows.Forms.Padding(0);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(91, 20);
            this.lbClave.TabIndex = 99;
            this.lbClave.Text = "Contraseña";
            this.lbClave.Click += new System.EventHandler(this.lbClave_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(305, 138);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(283, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUsuario.Location = new System.Drawing.Point(309, 142);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 20);
            this.lbUsuario.TabIndex = 99;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.Click += new System.EventHandler(this.lbUsuario_Click);
            // 
            // pbRandom
            // 
            this.pbRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRandom.Image = ((System.Drawing.Image)(resources.GetObject("pbRandom.Image")));
            this.pbRandom.Location = new System.Drawing.Point(0, 0);
            this.pbRandom.Name = "pbRandom";
            this.pbRandom.Size = new System.Drawing.Size(893, 453);
            this.pbRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRandom.TabIndex = 1;
            this.pbRandom.TabStop = false;
            this.pbRandom.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // pReconectando
            // 
            this.pReconectando.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pReconectando.Controls.Add(this.pictureBox1);
            this.pReconectando.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pReconectando.Location = new System.Drawing.Point(0, 411);
            this.pReconectando.Name = "pReconectando";
            this.pReconectando.Size = new System.Drawing.Size(893, 42);
            this.pReconectando.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 14;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerConexion
            // 
            this.timerConexion.Interval = 1000;
            this.timerConexion.Tick += new System.EventHandler(this.timerConexion_Tick);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(400, 82);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(87, 35);
            this.lbLogin.TabIndex = 99;
            this.lbLogin.Text = "Login";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 453);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pReconectando);
            this.Controls.Add(this.pbRandom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turismo Real - Iniciar Sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRandom)).EndInit();
            this.pReconectando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbRandom;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.LinkLabel btnRecuperar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Panel pReconectando;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerConexion;
        private System.Windows.Forms.Label lbLogin;
    }
}

