namespace TurismoRealEscritorio.Vistas.Finanzas
{
    partial class frmInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformes));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaInformes = new System.Windows.Forms.DataGridView();
            this.txtInforme = new System.Windows.Forms.TextBox();
            this.pBotones = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tablaServicios = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tablaReservas = new System.Windows.Forms.DataGridView();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbInformes = new System.Windows.Forms.Label();
            this.tablaEgresos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaUtilidades = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.deptoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contribuciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellinformes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInformes)).BeginInit();
            this.pBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUtilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1245, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtInforme);
            this.panel1.Controls.Add(this.tablaInformes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 629);
            this.panel1.TabIndex = 1;
            // 
            // tablaInformes
            // 
            this.tablaInformes.AllowUserToAddRows = false;
            this.tablaInformes.AllowUserToDeleteRows = false;
            this.tablaInformes.AllowUserToResizeColumns = false;
            this.tablaInformes.AllowUserToResizeRows = false;
            this.tablaInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInformes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInfo,
            this.cellinformes});
            this.tablaInformes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaInformes.Location = new System.Drawing.Point(13, 73);
            this.tablaInformes.MultiSelect = false;
            this.tablaInformes.Name = "tablaInformes";
            this.tablaInformes.RowHeadersVisible = false;
            this.tablaInformes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaInformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaInformes.Size = new System.Drawing.Size(174, 332);
            this.tablaInformes.TabIndex = 0;
            this.tablaInformes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CambiarElegido);
            // 
            // txtInforme
            // 
            this.txtInforme.BackColor = System.Drawing.Color.White;
            this.txtInforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInforme.Enabled = false;
            this.txtInforme.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtInforme.Location = new System.Drawing.Point(13, 12);
            this.txtInforme.Multiline = true;
            this.txtInforme.Name = "txtInforme";
            this.txtInforme.ReadOnly = true;
            this.txtInforme.Size = new System.Drawing.Size(174, 55);
            this.txtInforme.TabIndex = 32;
            this.txtInforme.Text = "A continuación, seleccione un informe para visualizar";
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.White;
            this.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBotones.Controls.Add(this.button2);
            this.pBotones.Controls.Add(this.button1);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotones.Location = new System.Drawing.Point(0, 629);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(1360, 73);
            this.pBotones.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(949, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generar PDF del informe actual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablaServicios
            // 
            this.tablaServicios.AllowUserToAddRows = false;
            this.tablaServicios.AllowUserToDeleteRows = false;
            this.tablaServicios.AllowUserToResizeColumns = false;
            this.tablaServicios.AllowUserToResizeRows = false;
            this.tablaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptoE,
            this.dividendo,
            this.contribuciones,
            this.mantenciones});
            this.tablaServicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaServicios.Location = new System.Drawing.Point(224, 344);
            this.tablaServicios.MultiSelect = false;
            this.tablaServicios.Name = "tablaServicios";
            this.tablaServicios.RowHeadersVisible = false;
            this.tablaServicios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaServicios.Size = new System.Drawing.Size(543, 126);
            this.tablaServicios.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(217, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 41);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ingresos por servicios";
            // 
            // tablaReservas
            // 
            this.tablaReservas.AllowUserToAddRows = false;
            this.tablaReservas.AllowUserToDeleteRows = false;
            this.tablaReservas.AllowUserToResizeColumns = false;
            this.tablaReservas.AllowUserToResizeRows = false;
            this.tablaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depto,
            this.costo,
            this.reservas,
            this.dias,
            this.ganancias});
            this.tablaReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaReservas.Location = new System.Drawing.Point(224, 155);
            this.tablaReservas.MultiSelect = false;
            this.tablaReservas.Name = "tablaReservas";
            this.tablaReservas.RowHeadersVisible = false;
            this.tablaReservas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaReservas.Size = new System.Drawing.Size(543, 126);
            this.tablaReservas.TabIndex = 27;
            // 
            // depto
            // 
            this.depto.HeaderText = "Departamento";
            this.depto.Name = "depto";
            this.depto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.depto.Width = 200;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo día";
            this.costo.Name = "costo";
            this.costo.Width = 110;
            // 
            // reservas
            // 
            this.reservas.HeaderText = "Reservas";
            this.reservas.Name = "reservas";
            this.reservas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reservas.Width = 60;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias totales";
            this.dias.Name = "dias";
            this.dias.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dias.Width = 60;
            // 
            // ganancias
            // 
            this.ganancias.HeaderText = "Ganancias";
            this.ganancias.Name = "ganancias";
            this.ganancias.Width = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(220, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Según departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 41);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ingresos por reservas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbInformes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 68);
            this.panel3.TabIndex = 30;
            // 
            // lbInformes
            // 
            this.lbInformes.AutoSize = true;
            this.lbInformes.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformes.Location = new System.Drawing.Point(16, 12);
            this.lbInformes.Name = "lbInformes";
            this.lbInformes.Size = new System.Drawing.Size(564, 41);
            this.lbInformes.TabIndex = 26;
            this.lbInformes.Text = "Informe periodo <MES>, año <AÑO>";
            // 
            // tablaEgresos
            // 
            this.tablaEgresos.AllowUserToAddRows = false;
            this.tablaEgresos.AllowUserToDeleteRows = false;
            this.tablaEgresos.AllowUserToResizeColumns = false;
            this.tablaEgresos.AllowUserToResizeRows = false;
            this.tablaEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tablaEgresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaEgresos.Location = new System.Drawing.Point(793, 155);
            this.tablaEgresos.MultiSelect = false;
            this.tablaEgresos.Name = "tablaEgresos";
            this.tablaEgresos.RowHeadersVisible = false;
            this.tablaEgresos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEgresos.Size = new System.Drawing.Size(543, 126);
            this.tablaEgresos.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 177;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dividendo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Contribuciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Mantenciones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Gasto total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 41);
            this.label2.TabIndex = 31;
            this.label2.Text = "Costos de departamentos";
            // 
            // tablaUtilidades
            // 
            this.tablaUtilidades.AllowUserToAddRows = false;
            this.tablaUtilidades.AllowUserToDeleteRows = false;
            this.tablaUtilidades.AllowUserToResizeColumns = false;
            this.tablaUtilidades.AllowUserToResizeRows = false;
            this.tablaUtilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUtilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tablaUtilidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaUtilidades.Location = new System.Drawing.Point(793, 344);
            this.tablaUtilidades.MultiSelect = false;
            this.tablaUtilidades.Name = "tablaUtilidades";
            this.tablaUtilidades.RowHeadersVisible = false;
            this.tablaUtilidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaUtilidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUtilidades.Size = new System.Drawing.Size(543, 126);
            this.tablaUtilidades.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(786, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 41);
            this.label3.TabIndex = 33;
            this.label3.Text = "Utilidades*";
            // 
            // deptoE
            // 
            this.deptoE.HeaderText = "Servicio";
            this.deptoE.Name = "deptoE";
            this.deptoE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deptoE.Width = 200;
            // 
            // dividendo
            // 
            this.dividendo.HeaderText = "Costo contratación";
            this.dividendo.Name = "dividendo";
            this.dividendo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dividendo.Width = 110;
            // 
            // contribuciones
            // 
            this.contribuciones.HeaderText = "Contrataciones";
            this.contribuciones.Name = "contribuciones";
            this.contribuciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contribuciones.Width = 110;
            // 
            // mantenciones
            // 
            this.mantenciones.HeaderText = "Ganancias";
            this.mantenciones.Name = "mantenciones";
            this.mantenciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mantenciones.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Costo mantención";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ganancias por reservas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Total utilidades";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // idInfo
            // 
            this.idInfo.HeaderText = "id";
            this.idInfo.Name = "idInfo";
            this.idInfo.Visible = false;
            // 
            // cellinformes
            // 
            this.cellinformes.HeaderText = "Informes";
            this.cellinformes.Name = "cellinformes";
            this.cellinformes.ReadOnly = true;
            this.cellinformes.Width = 174;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 702);
            this.Controls.Add(this.tablaUtilidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaEgresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tablaServicios);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tablaReservas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.frmInformes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInformes)).EndInit();
            this.pBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUtilidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaInformes;
        private System.Windows.Forms.DataGridViewTextBoxColumn informes;
        private System.Windows.Forms.TextBox txtInforme;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tablaServicios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView tablaReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbInformes;
        private System.Windows.Forms.DataGridView tablaEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaUtilidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dividendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contribuciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn mantenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellinformes;
    }
}