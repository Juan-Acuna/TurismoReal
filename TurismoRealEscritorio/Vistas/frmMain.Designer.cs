namespace TurismoRealEscritorio.Vista
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pReconectando = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenu = new System.Windows.Forms.Panel();
            this.lbTurismo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLogistica = new System.Windows.Forms.Button();
            this.btnDeptos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnFinanzas = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerConexion = new System.Windows.Forms.Timer(this.components);
            this.pReconectando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pReconectando
            // 
            this.pReconectando.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pReconectando.Controls.Add(this.pictureBox1);
            this.pReconectando.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pReconectando.Location = new System.Drawing.Point(215, 565);
            this.pReconectando.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pReconectando.Name = "pReconectando";
            this.pReconectando.Size = new System.Drawing.Size(1156, 52);
            this.pReconectando.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(356, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.White;
            this.pMenu.Controls.Add(this.lbTurismo);
            this.pMenu.Controls.Add(this.lbNombre);
            this.pMenu.Controls.Add(this.btnSalir);
            this.pMenu.Controls.Add(this.btnLogistica);
            this.pMenu.Controls.Add(this.btnDeptos);
            this.pMenu.Controls.Add(this.btnUsuarios);
            this.pMenu.Controls.Add(this.btnFinanzas);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(215, 617);
            this.pMenu.TabIndex = 4;
            // 
            // lbTurismo
            // 
            this.lbTurismo.AutoSize = true;
            this.lbTurismo.BackColor = System.Drawing.Color.Black;
            this.lbTurismo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTurismo.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurismo.ForeColor = System.Drawing.Color.White;
            this.lbTurismo.Location = new System.Drawing.Point(4, 11);
            this.lbTurismo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTurismo.Name = "lbTurismo";
            this.lbTurismo.Size = new System.Drawing.Size(197, 38);
            this.lbTurismo.TabIndex = 12;
            this.lbTurismo.Text = "Turismo Real";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbNombre.Location = new System.Drawing.Point(3, 530);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(191, 25);
            this.lbNombre.TabIndex = 11;
            this.lbNombre.Text = "Cargando usuario...";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(0, 559);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(213, 43);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogistica
            // 
            this.btnLogistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistica.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogistica.Location = new System.Drawing.Point(0, 308);
            this.btnLogistica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogistica.Name = "btnLogistica";
            this.btnLogistica.Size = new System.Drawing.Size(213, 43);
            this.btnLogistica.TabIndex = 8;
            this.btnLogistica.Text = "Gestión de Recursos";
            this.btnLogistica.UseVisualStyleBackColor = true;
            this.btnLogistica.Click += new System.EventHandler(this.btnLogistica_Click);
            // 
            // btnDeptos
            // 
            this.btnDeptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptos.Location = new System.Drawing.Point(0, 257);
            this.btnDeptos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeptos.Name = "btnDeptos";
            this.btnDeptos.Size = new System.Drawing.Size(213, 43);
            this.btnDeptos.TabIndex = 7;
            this.btnDeptos.Text = "Departamentos";
            this.btnDeptos.UseVisualStyleBackColor = true;
            this.btnDeptos.Click += new System.EventHandler(this.btnDeptos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 207);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(213, 43);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanzas.Location = new System.Drawing.Point(0, 156);
            this.btnFinanzas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Size = new System.Drawing.Size(213, 43);
            this.btnFinanzas.TabIndex = 5;
            this.btnFinanzas.Text = "Finanzas";
            this.btnFinanzas.UseVisualStyleBackColor = true;
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // pContainer
            // 
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(215, 0);
            this.pContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1156, 617);
            this.pContainer.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 14;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerConexion
            // 
            this.timerConexion.Tick += new System.EventHandler(this.timerConexion_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 617);
            this.Controls.Add(this.pReconectando);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pReconectando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pReconectando;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnFinanzas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLogistica;
        private System.Windows.Forms.Button btnDeptos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerConexion;
        public System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTurismo;
    }
}