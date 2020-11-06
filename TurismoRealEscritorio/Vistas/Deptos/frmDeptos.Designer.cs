namespace TurismoRealEscritorio.Vistas.Deptos
{
    partial class frmDeptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeptos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pEdicion = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContribuciones = new System.Windows.Forms.TextBox();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtArriendo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBanos = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.txtMCuadrados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImagenes = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.tablaDeptos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMantenciones = new System.Windows.Forms.Button();
            this.timerEdicion = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pEdicion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeptos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pEdicion);
            this.panel1.Controls.Add(this.tablaDeptos);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 343);
            this.panel1.TabIndex = 12;
            // 
            // pEdicion
            // 
            this.pEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEdicion.Controls.Add(this.groupBox2);
            this.pEdicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEdicion.Location = new System.Drawing.Point(0, 0);
            this.pEdicion.Name = "pEdicion";
            this.pEdicion.Size = new System.Drawing.Size(842, 343);
            this.pEdicion.TabIndex = 1;
            this.pEdicion.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.lbEstado);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnAplicar);
            this.groupBox2.Controls.Add(this.lbId);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 336);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Datos del Departamento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtContribuciones);
            this.groupBox4.Controls.Add(this.txtDividendo);
            this.groupBox4.Controls.Add(this.txtArriendo);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(561, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 217);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Financieros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(124, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 19);
            this.label11.TabIndex = 55;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(124, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 19);
            this.label12.TabIndex = 54;
            this.label12.Text = "$";
            // 
            // txtContribuciones
            // 
            this.txtContribuciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtContribuciones.Location = new System.Drawing.Point(147, 136);
            this.txtContribuciones.Name = "txtContribuciones";
            this.txtContribuciones.Size = new System.Drawing.Size(102, 24);
            this.txtContribuciones.TabIndex = 52;
            this.txtContribuciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloNumeros);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtDividendo.Location = new System.Drawing.Point(147, 99);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(102, 24);
            this.txtDividendo.TabIndex = 51;
            this.txtDividendo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloNumeros);
            // 
            // txtArriendo
            // 
            this.txtArriendo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtArriendo.Location = new System.Drawing.Point(147, 61);
            this.txtArriendo.Name = "txtArriendo";
            this.txtArriendo.Size = new System.Drawing.Size(102, 24);
            this.txtArriendo.TabIndex = 50;
            this.txtArriendo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloNumeros);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Contribuciones: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Arriendo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Dividendo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBanos);
            this.groupBox3.Controls.Add(this.txtHabitaciones);
            this.groupBox3.Controls.Add(this.txtMCuadrados);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(299, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 217);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medidas";
            // 
            // txtBanos
            // 
            this.txtBanos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtBanos.Location = new System.Drawing.Point(149, 136);
            this.txtBanos.Name = "txtBanos";
            this.txtBanos.Size = new System.Drawing.Size(88, 24);
            this.txtBanos.TabIndex = 49;
            this.txtBanos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloNumeros);
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtHabitaciones.Location = new System.Drawing.Point(149, 99);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(88, 24);
            this.txtHabitaciones.TabIndex = 48;
            this.txtHabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloNumeros);
            // 
            // txtMCuadrados
            // 
            this.txtMCuadrados.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtMCuadrados.Location = new System.Drawing.Point(149, 61);
            this.txtMCuadrados.Name = "txtMCuadrados";
            this.txtMCuadrados.Size = new System.Drawing.Size(88, 24);
            this.txtMCuadrados.TabIndex = 47;
            this.txtMCuadrados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloNumeros);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Metros Cuadrados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Baños:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Habitaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImagenes);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cbLocalidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 217);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logísticos";
            // 
            // btnImagenes
            // 
            this.btnImagenes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenes.Location = new System.Drawing.Point(186, 173);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(89, 32);
            this.btnImagenes.TabIndex = 55;
            this.btnImagenes.Text = "Imagenes";
            this.btnImagenes.UseVisualStyleBackColor = true;
            this.btnImagenes.Click += new System.EventHandler(this.btnImagenes_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "Localidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(121, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(154, 24);
            this.txtDireccion.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(121, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 24);
            this.txtNombre.TabIndex = 41;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(121, 134);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(154, 27);
            this.cbLocalidad.TabIndex = 40;
            this.cbLocalidad.Text = "Seleccione Localidad";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(272, 305);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(73, 19);
            this.txtEstado.TabIndex = 50;
            this.txtEstado.Text = "<Estado>";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(209, 305);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(57, 19);
            this.lbEstado.TabIndex = 49;
            this.lbEstado.Text = "Estado:";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(121, 305);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(43, 19);
            this.txtId.TabIndex = 48;
            this.txtId.Text = "<ID>";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(659, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 32);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(740, 298);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(88, 32);
            this.btnAplicar.TabIndex = 23;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(16, 305);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(99, 19);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Identificador:";
            // 
            // tablaDeptos
            // 
            this.tablaDeptos.AllowUserToAddRows = false;
            this.tablaDeptos.AllowUserToDeleteRows = false;
            this.tablaDeptos.AllowUserToResizeColumns = false;
            this.tablaDeptos.AllowUserToResizeRows = false;
            this.tablaDeptos.ColumnHeadersHeight = 25;
            this.tablaDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaDeptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDeptos.Location = new System.Drawing.Point(0, 0);
            this.tablaDeptos.MultiSelect = false;
            this.tablaDeptos.Name = "tablaDeptos";
            this.tablaDeptos.ReadOnly = true;
            this.tablaDeptos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaDeptos.RowHeadersVisible = false;
            this.tablaDeptos.RowHeadersWidth = 100;
            this.tablaDeptos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaDeptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDeptos.Size = new System.Drawing.Size(842, 343);
            this.tablaDeptos.StandardTab = true;
            this.tablaDeptos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gestion de Departamentos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(737, 445);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 32);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Nuevo Depto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(203, 445);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 32);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(112, 445);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 32);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(12, 445);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 32);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMantenciones
            // 
            this.btnMantenciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenciones.Location = new System.Drawing.Point(598, 445);
            this.btnMantenciones.Name = "btnMantenciones";
            this.btnMantenciones.Size = new System.Drawing.Size(120, 32);
            this.btnMantenciones.TabIndex = 54;
            this.btnMantenciones.Text = "Mantenciones";
            this.btnMantenciones.UseVisualStyleBackColor = true;
            this.btnMantenciones.Click += new System.EventHandler(this.btnMantenciones_Click);
            // 
            // timerEdicion
            // 
            this.timerEdicion.Interval = 7;
            this.timerEdicion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDeptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 501);
            this.ControlBox = false;
            this.Controls.Add(this.btnMantenciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeptos";
            this.Text = "frmDeptos";
            this.Load += new System.EventHandler(this.frmDeptos_Load);
            this.panel1.ResumeLayout(false);
            this.pEdicion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pEdicion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridView tablaDeptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtContribuciones;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtArriendo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBanos;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.TextBox txtMCuadrados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMantenciones;
        private System.Windows.Forms.Button btnImagenes;
        private System.Windows.Forms.Timer timerEdicion;
    }
}