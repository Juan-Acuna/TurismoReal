namespace TurismoRealEscritorio.Vistas.Deptos
{
    partial class frmMantenciones
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
            this.tablaManten = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pEdicion = new System.Windows.Forms.Panel();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.timerEdicion = new System.Windows.Forms.Timer(this.components);
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaManten)).BeginInit();
            this.panel1.SuspendLayout();
            this.pEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaManten
            // 
            this.tablaManten.AllowUserToAddRows = false;
            this.tablaManten.AllowUserToDeleteRows = false;
            this.tablaManten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaManten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaManten.Location = new System.Drawing.Point(0, 0);
            this.tablaManten.Name = "tablaManten";
            this.tablaManten.ReadOnly = true;
            this.tablaManten.RowHeadersVisible = false;
            this.tablaManten.Size = new System.Drawing.Size(532, 281);
            this.tablaManten.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(456, 310);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 32);
            this.btnVolver.TabIndex = 60;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pEdicion);
            this.panel1.Controls.Add(this.tablaManten);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 281);
            this.panel1.TabIndex = 61;
            // 
            // pEdicion
            // 
            this.pEdicion.Controls.Add(this.cbTipo);
            this.pEdicion.Controls.Add(this.label2);
            this.pEdicion.Controls.Add(this.btnCancelar);
            this.pEdicion.Controls.Add(this.btnAplicar);
            this.pEdicion.Controls.Add(this.label1);
            this.pEdicion.Controls.Add(this.cbFuncionario);
            this.pEdicion.Controls.Add(this.dtFecha);
            this.pEdicion.Controls.Add(this.label8);
            this.pEdicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEdicion.Location = new System.Drawing.Point(0, 0);
            this.pEdicion.Name = "pEdicion";
            this.pEdicion.Size = new System.Drawing.Size(532, 281);
            this.pEdicion.TabIndex = 1;
            this.pEdicion.Visible = false;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(295, 310);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(155, 32);
            this.btnAgendar.TabIndex = 62;
            this.btnAgendar.Text = "Agendar Mantención";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // timerEdicion
            // 
            this.timerEdicion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(154, 32);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(154, 27);
            this.cbFuncionario.TabIndex = 63;
            this.cbFuncionario.Text = "Seleccione Funcionario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Funcionario:";
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(154, 77);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(154, 24);
            this.dtFecha.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Fecha mantención:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(425, 229);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(89, 32);
            this.btnAplicar.TabIndex = 63;
            this.btnAplicar.Text = "Agendar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(318, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(154, 121);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(154, 27);
            this.cbTipo.TabIndex = 67;
            this.cbTipo.Text = "Seleccione Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tipo Mantención:";
            // 
            // frmMantenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 360);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmMantenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenciones";
            this.Load += new System.EventHandler(this.frmMantenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaManten)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pEdicion.ResumeLayout(false);
            this.pEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaManten;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pEdicion;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Timer timerEdicion;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
    }
}