namespace TurismoRealEscritorio.Vistas.Finanzas
{
    partial class frmFinanzas
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
            this.contMaestro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pDeptos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbHD5 = new System.Windows.Forms.Label();
            this.txtE5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbHD1 = new System.Windows.Forms.Label();
            this.txtE1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbHD2 = new System.Windows.Forms.Label();
            this.txtE2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbHD4 = new System.Windows.Forms.Label();
            this.txtE4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbHD3 = new System.Windows.Forms.Label();
            this.txtE3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pVistaGeneral = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMNM = new System.Windows.Forms.Label();
            this.txtNMantenciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMNR = new System.Windows.Forms.Label();
            this.txtNReservas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHT = new System.Windows.Forms.Label();
            this.txtMNT = new System.Windows.Forms.Label();
            this.txtNTransacciones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pConexiones = new System.Windows.Forms.Panel();
            this.lbHC = new System.Windows.Forms.Label();
            this.txtNConectados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pInforme = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.txtInforme = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TablaEgresos = new System.Windows.Forms.DataGridView();
            this.deptoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contribuciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.tablaReservas = new System.Windows.Forms.DataGridView();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHR = new System.Windows.Forms.Label();
            this.lbHM = new System.Windows.Forms.Label();
            this.contMaestro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pDeptos.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pVistaGeneral.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pConexiones.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // contMaestro
            // 
            this.contMaestro.Controls.Add(this.tabPage1);
            this.contMaestro.Controls.Add(this.tabPage2);
            this.contMaestro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contMaestro.Location = new System.Drawing.Point(0, 56);
            this.contMaestro.Margin = new System.Windows.Forms.Padding(2);
            this.contMaestro.Name = "contMaestro";
            this.contMaestro.SelectedIndex = 0;
            this.contMaestro.Size = new System.Drawing.Size(867, 445);
            this.contMaestro.TabIndex = 0;
            this.contMaestro.SelectedIndexChanged += new System.EventHandler(this.CambiarTab);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pDeptos);
            this.tabPage1.Controls.Add(this.pVistaGeneral);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(859, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estadísticas Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pDeptos
            // 
            this.pDeptos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDeptos.Controls.Add(this.label3);
            this.pDeptos.Controls.Add(this.panel9);
            this.pDeptos.Controls.Add(this.panel11);
            this.pDeptos.Controls.Add(this.label8);
            this.pDeptos.Controls.Add(this.panel6);
            this.pDeptos.Controls.Add(this.panel8);
            this.pDeptos.Controls.Add(this.panel7);
            this.pDeptos.Location = new System.Drawing.Point(556, 5);
            this.pDeptos.Margin = new System.Windows.Forms.Padding(2);
            this.pDeptos.Name = "pDeptos";
            this.pDeptos.Size = new System.Drawing.Size(299, 411);
            this.pDeptos.TabIndex = 15;
            this.pDeptos.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(4, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "En tiempo real.";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lbHD5);
            this.panel9.Controls.Add(this.txtE5);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Location = new System.Drawing.Point(60, 344);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(173, 54);
            this.panel9.TabIndex = 19;
            this.panel9.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // lbHD5
            // 
            this.lbHD5.AutoSize = true;
            this.lbHD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHD5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHD5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD5.Location = new System.Drawing.Point(157, -1);
            this.lbHD5.Name = "lbHD5";
            this.lbHD5.Size = new System.Drawing.Size(15, 18);
            this.lbHD5.TabIndex = 22;
            this.lbHD5.Text = "?";
            this.lbHD5.Click += new System.EventHandler(this.ActivarTipDepto);
            // 
            // txtE5
            // 
            this.txtE5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtE5.AutoSize = true;
            this.txtE5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE5.Location = new System.Drawing.Point(150, 27);
            this.txtE5.Name = "txtE5";
            this.txtE5.Size = new System.Drawing.Size(20, 22);
            this.txtE5.TabIndex = 8;
            this.txtE5.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 25);
            this.label16.TabIndex = 7;
            this.label16.Text = "Inhabitable";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.lbHD1);
            this.panel11.Controls.Add(this.txtE1);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(59, 76);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(174, 54);
            this.panel11.TabIndex = 15;
            this.panel11.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // lbHD1
            // 
            this.lbHD1.AutoSize = true;
            this.lbHD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHD1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD1.Location = new System.Drawing.Point(158, -1);
            this.lbHD1.Name = "lbHD1";
            this.lbHD1.Size = new System.Drawing.Size(15, 18);
            this.lbHD1.TabIndex = 20;
            this.lbHD1.Text = "?";
            this.lbHD1.Click += new System.EventHandler(this.ActivarTipDepto);
            // 
            // txtE1
            // 
            this.txtE1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtE1.AutoSize = true;
            this.txtE1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE1.Location = new System.Drawing.Point(150, 27);
            this.txtE1.Name = "txtE1";
            this.txtE1.Size = new System.Drawing.Size(20, 22);
            this.txtE1.TabIndex = 8;
            this.txtE1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "No Disponible";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Monitor de departamentos.";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbHD2);
            this.panel6.Controls.Add(this.txtE2);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(59, 143);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 54);
            this.panel6.TabIndex = 16;
            this.panel6.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // lbHD2
            // 
            this.lbHD2.AutoSize = true;
            this.lbHD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHD2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD2.Location = new System.Drawing.Point(158, -1);
            this.lbHD2.Name = "lbHD2";
            this.lbHD2.Size = new System.Drawing.Size(15, 18);
            this.lbHD2.TabIndex = 10;
            this.lbHD2.Text = "?";
            this.lbHD2.Click += new System.EventHandler(this.ActivarTipDepto);
            // 
            // txtE2
            // 
            this.txtE2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtE2.AutoSize = true;
            this.txtE2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE2.Location = new System.Drawing.Point(150, 27);
            this.txtE2.Name = "txtE2";
            this.txtE2.Size = new System.Drawing.Size(20, 22);
            this.txtE2.TabIndex = 8;
            this.txtE2.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Disponible";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lbHD4);
            this.panel8.Controls.Add(this.txtE4);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Location = new System.Drawing.Point(60, 277);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(173, 54);
            this.panel8.TabIndex = 18;
            this.panel8.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // lbHD4
            // 
            this.lbHD4.AutoSize = true;
            this.lbHD4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHD4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHD4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD4.Location = new System.Drawing.Point(157, -1);
            this.lbHD4.Name = "lbHD4";
            this.lbHD4.Size = new System.Drawing.Size(15, 18);
            this.lbHD4.TabIndex = 12;
            this.lbHD4.Text = "?";
            this.lbHD4.Click += new System.EventHandler(this.ActivarTipDepto);
            // 
            // txtE4
            // 
            this.txtE4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtE4.AutoSize = true;
            this.txtE4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE4.Location = new System.Drawing.Point(150, 27);
            this.txtE4.Name = "txtE4";
            this.txtE4.Size = new System.Drawing.Size(20, 22);
            this.txtE4.TabIndex = 8;
            this.txtE4.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "En Mantención";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbHD3);
            this.panel7.Controls.Add(this.txtE3);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(60, 210);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(173, 54);
            this.panel7.TabIndex = 17;
            this.panel7.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // lbHD3
            // 
            this.lbHD3.AutoSize = true;
            this.lbHD3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHD3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHD3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD3.Location = new System.Drawing.Point(157, -1);
            this.lbHD3.Name = "lbHD3";
            this.lbHD3.Size = new System.Drawing.Size(15, 18);
            this.lbHD3.TabIndex = 11;
            this.lbHD3.Text = "?";
            this.lbHD3.Click += new System.EventHandler(this.ActivarTipDepto);
            // 
            // txtE3
            // 
            this.txtE3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtE3.AutoSize = true;
            this.txtE3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE3.Location = new System.Drawing.Point(150, 27);
            this.txtE3.Name = "txtE3";
            this.txtE3.Size = new System.Drawing.Size(20, 22);
            this.txtE3.TabIndex = 8;
            this.txtE3.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Reservado";
            // 
            // pVistaGeneral
            // 
            this.pVistaGeneral.Controls.Add(this.label17);
            this.pVistaGeneral.Controls.Add(this.panel4);
            this.pVistaGeneral.Controls.Add(this.panel3);
            this.pVistaGeneral.Controls.Add(this.panel2);
            this.pVistaGeneral.Controls.Add(this.pConexiones);
            this.pVistaGeneral.Location = new System.Drawing.Point(6, 5);
            this.pVistaGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.pVistaGeneral.Name = "pVistaGeneral";
            this.pVistaGeneral.Size = new System.Drawing.Size(546, 410);
            this.pVistaGeneral.TabIndex = 14;
            this.pVistaGeneral.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(202, 41);
            this.label17.TabIndex = 19;
            this.label17.Text = "Vista general";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbHM);
            this.panel4.Controls.Add(this.txtMNM);
            this.panel4.Controls.Add(this.txtNMantenciones);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(288, 274);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 87);
            this.panel4.TabIndex = 17;
            this.panel4.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // txtMNM
            // 
            this.txtMNM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMNM.AutoSize = true;
            this.txtMNM.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNM.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMNM.Location = new System.Drawing.Point(26, 32);
            this.txtMNM.Name = "txtMNM";
            this.txtMNM.Size = new System.Drawing.Size(120, 16);
            this.txtMNM.TabIndex = 10;
            this.txtMNM.Text = "(Cargando Periodo...)";
            // 
            // txtNMantenciones
            // 
            this.txtNMantenciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNMantenciones.AutoSize = true;
            this.txtNMantenciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNMantenciones.Location = new System.Drawing.Point(181, 56);
            this.txtNMantenciones.Name = "txtNMantenciones";
            this.txtNMantenciones.Size = new System.Drawing.Size(35, 22);
            this.txtNMantenciones.TabIndex = 8;
            this.txtNMantenciones.Text = "   0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "N° Mantenciones";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbHR);
            this.panel3.Controls.Add(this.txtMNR);
            this.panel3.Controls.Add(this.txtNReservas);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(22, 274);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 87);
            this.panel3.TabIndex = 18;
            this.panel3.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // txtMNR
            // 
            this.txtMNR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMNR.AutoSize = true;
            this.txtMNR.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNR.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMNR.Location = new System.Drawing.Point(26, 32);
            this.txtMNR.Name = "txtMNR";
            this.txtMNR.Size = new System.Drawing.Size(120, 16);
            this.txtMNR.TabIndex = 9;
            this.txtMNR.Text = "(Cargando Periodo...)";
            // 
            // txtNReservas
            // 
            this.txtNReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNReservas.AutoSize = true;
            this.txtNReservas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNReservas.Location = new System.Drawing.Point(186, 56);
            this.txtNReservas.Name = "txtNReservas";
            this.txtNReservas.Size = new System.Drawing.Size(35, 22);
            this.txtNReservas.TabIndex = 8;
            this.txtNReservas.Text = "   0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "N° Reservas";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbHT);
            this.panel2.Controls.Add(this.txtMNT);
            this.panel2.Controls.Add(this.txtNTransacciones);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(288, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 87);
            this.panel2.TabIndex = 16;
            this.panel2.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHT.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT.Location = new System.Drawing.Point(216, -1);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(15, 18);
            this.lbHT.TabIndex = 10;
            this.lbHT.Text = "?";
            this.lbHT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbHT.Click += new System.EventHandler(this.ActivarTipTrans);
            // 
            // txtMNT
            // 
            this.txtMNT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMNT.AutoSize = true;
            this.txtMNT.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNT.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMNT.Location = new System.Drawing.Point(26, 32);
            this.txtMNT.Name = "txtMNT";
            this.txtMNT.Size = new System.Drawing.Size(101, 16);
            this.txtMNT.TabIndex = 9;
            this.txtMNT.Text = "(Cargando Mes...)";
            // 
            // txtNTransacciones
            // 
            this.txtNTransacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNTransacciones.AutoSize = true;
            this.txtNTransacciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTransacciones.Location = new System.Drawing.Point(181, 56);
            this.txtNTransacciones.Name = "txtNTransacciones";
            this.txtNTransacciones.Size = new System.Drawing.Size(35, 22);
            this.txtNTransacciones.TabIndex = 8;
            this.txtNTransacciones.Text = "   0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "N° Transacciones";
            // 
            // pConexiones
            // 
            this.pConexiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pConexiones.Controls.Add(this.lbHC);
            this.pConexiones.Controls.Add(this.txtNConectados);
            this.pConexiones.Controls.Add(this.label2);
            this.pConexiones.Location = new System.Drawing.Point(22, 144);
            this.pConexiones.Margin = new System.Windows.Forms.Padding(2);
            this.pConexiones.Name = "pConexiones";
            this.pConexiones.Size = new System.Drawing.Size(232, 87);
            this.pConexiones.TabIndex = 15;
            this.pConexiones.Click += new System.EventHandler(this.DesactivarTips);
            // 
            // lbHC
            // 
            this.lbHC.AutoSize = true;
            this.lbHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHC.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHC.Location = new System.Drawing.Point(216, -1);
            this.lbHC.Name = "lbHC";
            this.lbHC.Size = new System.Drawing.Size(15, 18);
            this.lbHC.TabIndex = 9;
            this.lbHC.Text = "?";
            this.lbHC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbHC.Click += new System.EventHandler(this.lbHC_Click);
            // 
            // txtNConectados
            // 
            this.txtNConectados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNConectados.AutoSize = true;
            this.txtNConectados.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNConectados.Location = new System.Drawing.Point(166, 56);
            this.txtNConectados.Name = "txtNConectados";
            this.txtNConectados.Size = new System.Drawing.Size(58, 22);
            this.txtNConectados.TabIndex = 8;
            this.txtNConectados.Text = "    0/0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuarios conectados";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pInforme);
            this.tabPage2.Controls.Add(this.TablaEgresos);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tablaReservas);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(859, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingresos y Egresos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pInforme
            // 
            this.pInforme.BackColor = System.Drawing.Color.White;
            this.pInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInforme.Controls.Add(this.textBox1);
            this.pInforme.Controls.Add(this.button1);
            this.pInforme.Controls.Add(this.btnPDF);
            this.pInforme.Controls.Add(this.txtInforme);
            this.pInforme.Controls.Add(this.label18);
            this.pInforme.Controls.Add(this.label15);
            this.pInforme.Location = new System.Drawing.Point(592, 4);
            this.pInforme.Margin = new System.Windows.Forms.Padding(2);
            this.pInforme.Name = "pInforme";
            this.pInforme.Size = new System.Drawing.Size(263, 411);
            this.pInforme.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(11, 310);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 62);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "Para ver informes de periodos anteriores, presione el botón \'Historial de informe" +
    "s\'.";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.button1.Location = new System.Drawing.Point(110, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "Historial de informes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.btnPDF.Location = new System.Drawing.Point(92, 261);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(166, 28);
            this.btnPDF.TabIndex = 30;
            this.btnPDF.Text = "Generar Informe (PDF)";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // txtInforme
            // 
            this.txtInforme.BackColor = System.Drawing.Color.White;
            this.txtInforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInforme.Enabled = false;
            this.txtInforme.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtInforme.Location = new System.Drawing.Point(11, 83);
            this.txtInforme.Multiline = true;
            this.txtInforme.Name = "txtInforme";
            this.txtInforme.ReadOnly = true;
            this.txtInforme.Size = new System.Drawing.Size(240, 172);
            this.txtInforme.TabIndex = 31;
            this.txtInforme.Text = "El informe de ingresos y egresos esta disponible desde el primer día del mes sigu" +
    "iente, mostrando un balance total del mes.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(10, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "de ingresos y egresos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 62);
            this.label15.TabIndex = 26;
            this.label15.Text = "Informe";
            // 
            // TablaEgresos
            // 
            this.TablaEgresos.AllowUserToAddRows = false;
            this.TablaEgresos.AllowUserToDeleteRows = false;
            this.TablaEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptoE,
            this.dividendo,
            this.contribuciones,
            this.mantenciones,
            this.gasto});
            this.TablaEgresos.Location = new System.Drawing.Point(26, 285);
            this.TablaEgresos.Name = "TablaEgresos";
            this.TablaEgresos.ReadOnly = true;
            this.TablaEgresos.RowHeadersVisible = false;
            this.TablaEgresos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TablaEgresos.Size = new System.Drawing.Size(543, 126);
            this.TablaEgresos.TabIndex = 24;
            // 
            // deptoE
            // 
            this.deptoE.HeaderText = "Departamento";
            this.deptoE.Name = "deptoE";
            this.deptoE.ReadOnly = true;
            this.deptoE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deptoE.Width = 177;
            // 
            // dividendo
            // 
            this.dividendo.HeaderText = "Dividendo";
            this.dividendo.Name = "dividendo";
            this.dividendo.ReadOnly = true;
            this.dividendo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dividendo.Width = 88;
            // 
            // contribuciones
            // 
            this.contribuciones.HeaderText = "Contribuciones";
            this.contribuciones.Name = "contribuciones";
            this.contribuciones.ReadOnly = true;
            this.contribuciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contribuciones.Width = 88;
            // 
            // mantenciones
            // 
            this.mantenciones.HeaderText = "Mantenciones";
            this.mantenciones.Name = "mantenciones";
            this.mantenciones.ReadOnly = true;
            this.mantenciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mantenciones.Width = 88;
            // 
            // gasto
            // 
            this.gasto.HeaderText = "Gasto total";
            this.gasto.Name = "gasto";
            this.gasto.ReadOnly = true;
            this.gasto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(383, 41);
            this.label13.TabIndex = 23;
            this.label13.Text = "Costos de departamentos";
            // 
            // tablaReservas
            // 
            this.tablaReservas.AllowUserToAddRows = false;
            this.tablaReservas.AllowUserToDeleteRows = false;
            this.tablaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depto,
            this.costo,
            this.reservas,
            this.dias,
            this.ganancias});
            this.tablaReservas.Location = new System.Drawing.Point(26, 96);
            this.tablaReservas.Name = "tablaReservas";
            this.tablaReservas.ReadOnly = true;
            this.tablaReservas.RowHeadersVisible = false;
            this.tablaReservas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaReservas.Size = new System.Drawing.Size(543, 126);
            this.tablaReservas.TabIndex = 22;
            // 
            // depto
            // 
            this.depto.HeaderText = "Departamento";
            this.depto.Name = "depto";
            this.depto.ReadOnly = true;
            this.depto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.depto.Width = 200;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo día";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 110;
            // 
            // reservas
            // 
            this.reservas.HeaderText = "Reservas";
            this.reservas.Name = "reservas";
            this.reservas.ReadOnly = true;
            this.reservas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reservas.Width = 60;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias totales";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dias.Width = 60;
            // 
            // ganancias
            // 
            this.ganancias.HeaderText = "Ganancias";
            this.ganancias.Name = "ganancias";
            this.ganancias.ReadOnly = true;
            this.ganancias.Width = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(22, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Según departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 41);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ingresos por reservas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Finanzas";
            // 
            // lbHR
            // 
            this.lbHR.AutoSize = true;
            this.lbHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHR.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHR.Location = new System.Drawing.Point(216, -1);
            this.lbHR.Name = "lbHR";
            this.lbHR.Size = new System.Drawing.Size(15, 18);
            this.lbHR.TabIndex = 11;
            this.lbHR.Text = "?";
            this.lbHR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbHR.Click += new System.EventHandler(this.ActivarTipRes);
            // 
            // lbHM
            // 
            this.lbHM.AutoSize = true;
            this.lbHM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHM.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHM.Location = new System.Drawing.Point(216, -1);
            this.lbHM.Name = "lbHM";
            this.lbHM.Size = new System.Drawing.Size(15, 18);
            this.lbHM.TabIndex = 12;
            this.lbHM.Text = "?";
            this.lbHM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbHM.Click += new System.EventHandler(this.ActivarTipMan);
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 501);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contMaestro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFinanzas";
            this.Text = "frmFinanzas";
            this.Load += new System.EventHandler(this.frmFinanzas_Load);
            this.Click += new System.EventHandler(this.DesactivarTips);
            this.contMaestro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pDeptos.ResumeLayout(false);
            this.pDeptos.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pVistaGeneral.ResumeLayout(false);
            this.pVistaGeneral.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pConexiones.ResumeLayout(false);
            this.pConexiones.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pInforme.ResumeLayout(false);
            this.pInforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl contMaestro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pDeptos;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label txtE5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label txtE4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label txtE3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtE2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label txtE1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pVistaGeneral;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtMNR;
        private System.Windows.Forms.Label txtNReservas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pConexiones;
        private System.Windows.Forms.Label txtNConectados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtMNM;
        private System.Windows.Forms.Label txtNMantenciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtMNT;
        private System.Windows.Forms.Label txtNTransacciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHD5;
        private System.Windows.Forms.Label lbHD1;
        private System.Windows.Forms.Label lbHD2;
        private System.Windows.Forms.Label lbHD3;
        private System.Windows.Forms.DataGridView tablaReservas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancias;
        private System.Windows.Forms.Panel pInforme;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView TablaEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dividendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contribuciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn mantenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.TextBox txtInforme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbHD4;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbHM;
        private System.Windows.Forms.Label lbHR;
    }
}