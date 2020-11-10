namespace TurismoRealEscritorio.Vistas.Usuarios
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pEdicion = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbErrorE = new System.Windows.Forms.Label();
            this.lbErrorR = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbComuna = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbErrorU = new System.Windows.Forms.Label();
            this.pClave = new System.Windows.Forms.Panel();
            this.btnOjo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkClave = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFrecuente = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbFrecuente = new System.Windows.Forms.Label();
            this.timerEdicion = new System.Windows.Forms.Timer(this.components);
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.imgAbiertoCont = new System.Windows.Forms.PictureBox();
            this.imgCerradoCont = new System.Windows.Forms.PictureBox();
            this.imgAbriendoCont = new System.Windows.Forms.PictureBox();
            this.imgCerrandoCont = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.pEdicion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOjo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbiertoCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerradoCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbriendoCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrandoCont)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.AllowUserToDeleteRows = false;
            this.tablaUsuarios.AllowUserToResizeColumns = false;
            this.tablaUsuarios.AllowUserToResizeRows = false;
            this.tablaUsuarios.ColumnHeadersHeight = 25;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tablaUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaUsuarios.MultiSelect = false;
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaUsuarios.RowHeadersVisible = false;
            this.tablaUsuarios.RowHeadersWidth = 100;
            this.tablaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUsuarios.Size = new System.Drawing.Size(1123, 422);
            this.tablaUsuarios.StandardTab = true;
            this.tablaUsuarios.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(17, 538);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 39);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(151, 538);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(984, 538);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 39);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Nuevo usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestion de Usuarios";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pEdicion);
            this.panel1.Controls.Add(this.tablaUsuarios);
            this.panel1.Location = new System.Drawing.Point(17, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 422);
            this.panel1.TabIndex = 6;
            // 
            // pEdicion
            // 
            this.pEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEdicion.Controls.Add(this.groupBox2);
            this.pEdicion.Controls.Add(this.groupBox1);
            this.pEdicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEdicion.Location = new System.Drawing.Point(0, 0);
            this.pEdicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pEdicion.Name = "pEdicion";
            this.pEdicion.Size = new System.Drawing.Size(1123, 422);
            this.pEdicion.TabIndex = 1;
            this.pEdicion.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbErrorE);
            this.groupBox2.Controls.Add(this.lbErrorR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbComuna);
            this.groupBox2.Controls.Add(this.cbRegion);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.txtRut);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnAplicar);
            this.groupBox2.Controls.Add(this.cbGenero);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.dtNacimiento);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(293, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(823, 414);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Datos Personales";
            // 
            // lbErrorE
            // 
            this.lbErrorE.AutoSize = true;
            this.lbErrorE.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorE.ForeColor = System.Drawing.Color.Red;
            this.lbErrorE.Location = new System.Drawing.Point(17, 298);
            this.lbErrorE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorE.Name = "lbErrorE";
            this.lbErrorE.Size = new System.Drawing.Size(13, 20);
            this.lbErrorE.TabIndex = 32;
            this.lbErrorE.Text = ".";
            this.lbErrorE.Visible = false;
            // 
            // lbErrorR
            // 
            this.lbErrorR.AutoSize = true;
            this.lbErrorR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorR.ForeColor = System.Drawing.Color.Red;
            this.lbErrorR.Location = new System.Drawing.Point(17, 87);
            this.lbErrorR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorR.Name = "lbErrorR";
            this.lbErrorR.Size = new System.Drawing.Size(13, 20);
            this.lbErrorR.TabIndex = 31;
            this.lbErrorR.Text = ".";
            this.lbErrorR.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 99;
            this.label7.Text = "(+56)";
            // 
            // cbComuna
            // 
            this.cbComuna.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbComuna.FormattingEnabled = true;
            this.cbComuna.Location = new System.Drawing.Point(559, 267);
            this.cbComuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbComuna.Name = "cbComuna";
            this.cbComuna.Size = new System.Drawing.Size(244, 29);
            this.cbComuna.TabIndex = 14;
            this.cbComuna.Text = "Seleccione Comuna";
            // 
            // cbRegion
            // 
            this.cbRegion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(559, 214);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(244, 29);
            this.cbRegion.TabIndex = 13;
            this.cbRegion.Text = "Seleccione Region";
            this.cbRegion.SelectionChangeCommitted += new System.EventHandler(this.cbRegion_SelectionChangeCommitted);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(559, 166);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.MaxLength = 25;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(244, 28);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtRut.Location = new System.Drawing.Point(208, 54);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRut.MaxLength = 13;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(241, 28);
            this.txtRut.TabIndex = 5;
            this.txtRut.TextChanged += new System.EventHandler(this.VerificarDisponibilidad);
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormatearRut);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(589, 367);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 39);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(697, 367);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(117, 39);
            this.btnAplicar.TabIndex = 16;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(208, 322);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(241, 29);
            this.cbGenero.TabIndex = 10;
            this.cbGenero.Text = "Seleccione Genero";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(208, 267);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 49;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 28);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.VerificarDisponibilidad);
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(208, 214);
            this.dtNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(241, 28);
            this.dtNacimiento.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtApellidos.Location = new System.Drawing.Point(208, 164);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.MaxLength = 49;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(241, 28);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloLetras);
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtNombres.Location = new System.Drawing.Point(208, 107);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.MaxLength = 49;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(241, 28);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloLetras);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtTelefono.Location = new System.Drawing.Point(611, 107);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(192, 28);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarSoloNumeros);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 325);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 23);
            this.label18.TabIndex = 99;
            this.label18.Text = "Genero:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(459, 218);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 23);
            this.label17.TabIndex = 99;
            this.label17.Text = "Region:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(459, 167);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 23);
            this.label16.TabIndex = 99;
            this.label16.Text = "Direccion:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(459, 271);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 23);
            this.label15.TabIndex = 99;
            this.label15.Text = "Comuna:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(459, 111);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 23);
            this.label14.TabIndex = 99;
            this.label14.Text = "Telefono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 271);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 23);
            this.label13.TabIndex = 99;
            this.label13.Text = "Correo Electronico:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 222);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 23);
            this.label11.TabIndex = 99;
            this.label11.Text = "Fecha Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 23);
            this.label10.TabIndex = 99;
            this.label10.Text = "Apellidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 99;
            this.label9.Text = "Nombres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 99;
            this.label6.Text = "Rut:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbErrorU);
            this.groupBox1.Controls.Add(this.pClave);
            this.groupBox1.Controls.Add(this.chkClave);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtFrecuente);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.cbRol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbEstado);
            this.groupBox1.Controls.Add(this.lbFrecuente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(281, 412);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Datos de Usuario ";
            // 
            // lbErrorU
            // 
            this.lbErrorU.AutoSize = true;
            this.lbErrorU.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorU.ForeColor = System.Drawing.Color.Red;
            this.lbErrorU.Location = new System.Drawing.Point(8, 87);
            this.lbErrorU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorU.Name = "lbErrorU";
            this.lbErrorU.Size = new System.Drawing.Size(13, 20);
            this.lbErrorU.TabIndex = 30;
            this.lbErrorU.Text = ".";
            this.lbErrorU.Visible = false;
            // 
            // pClave
            // 
            this.pClave.Controls.Add(this.btnOjo);
            this.pClave.Controls.Add(this.label5);
            this.pClave.Controls.Add(this.txtClave);
            this.pClave.Enabled = false;
            this.pClave.Location = new System.Drawing.Point(8, 298);
            this.pClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pClave.Name = "pClave";
            this.pClave.Size = new System.Drawing.Size(265, 107);
            this.pClave.TabIndex = 30;
            // 
            // btnOjo
            // 
            this.btnOjo.Location = new System.Drawing.Point(217, 57);
            this.btnOjo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOjo.Name = "btnOjo";
            this.btnOjo.Size = new System.Drawing.Size(29, 27);
            this.btnOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOjo.TabIndex = 30;
            this.btnOjo.TabStop = false;
            this.btnOjo.Click += new System.EventHandler(this.btnOjo_Click);
            this.btnOjo.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOjo_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 99;
            this.label5.Text = "Nueva Contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.Window;
            this.txtClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtClave.Location = new System.Drawing.Point(19, 57);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.MaxLength = 15;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(188, 28);
            this.txtClave.TabIndex = 4;
            // 
            // chkClave
            // 
            this.chkClave.AutoSize = true;
            this.chkClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.chkClave.Location = new System.Drawing.Point(5, 262);
            this.chkClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkClave.Name = "chkClave";
            this.chkClave.Size = new System.Drawing.Size(194, 27);
            this.chkClave.TabIndex = 3;
            this.chkClave.Text = "Cambiar Contraseña";
            this.chkClave.UseVisualStyleBackColor = true;
            this.chkClave.CheckedChanged += new System.EventHandler(this.chkClave_CheckedChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtUsername.Location = new System.Drawing.Point(101, 57);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.MaxLength = 15;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.VerificarDisponibilidad);
            // 
            // txtFrecuente
            // 
            this.txtFrecuente.AutoSize = true;
            this.txtFrecuente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrecuente.Location = new System.Drawing.Point(96, 217);
            this.txtFrecuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFrecuente.Name = "txtFrecuente";
            this.txtFrecuente.Size = new System.Drawing.Size(116, 23);
            this.txtFrecuente.TabIndex = 99;
            this.txtFrecuente.Text = "<Frecuente>";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.chkActivo.Location = new System.Drawing.Point(101, 166);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(84, 27);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(101, 110);
            this.cbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(152, 29);
            this.cbRol.TabIndex = 1;
            this.cbRol.Text = "Seleccione Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 99;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 99;
            this.label3.Text = "Rol:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(0, 166);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(68, 23);
            this.lbEstado.TabIndex = 99;
            this.lbEstado.Text = "Estado:";
            // 
            // lbFrecuente
            // 
            this.lbFrecuente.AutoSize = true;
            this.lbFrecuente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrecuente.Location = new System.Drawing.Point(0, 217);
            this.lbFrecuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFrecuente.Name = "lbFrecuente";
            this.lbFrecuente.Size = new System.Drawing.Size(94, 23);
            this.lbFrecuente.TabIndex = 99;
            this.lbFrecuente.Text = "Frecuente:";
            // 
            // timerEdicion
            // 
            this.timerEdicion.Interval = 7;
            this.timerEdicion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Enabled = false;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(272, 538);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(100, 39);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // imgAbiertoCont
            // 
            this.imgAbiertoCont.Image = ((System.Drawing.Image)(resources.GetObject("imgAbiertoCont.Image")));
            this.imgAbiertoCont.Location = new System.Drawing.Point(479, 538);
            this.imgAbiertoCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgAbiertoCont.Name = "imgAbiertoCont";
            this.imgAbiertoCont.Size = new System.Drawing.Size(29, 27);
            this.imgAbiertoCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAbiertoCont.TabIndex = 31;
            this.imgAbiertoCont.TabStop = false;
            this.imgAbiertoCont.Visible = false;
            // 
            // imgCerradoCont
            // 
            this.imgCerradoCont.Image = ((System.Drawing.Image)(resources.GetObject("imgCerradoCont.Image")));
            this.imgCerradoCont.Location = new System.Drawing.Point(535, 538);
            this.imgCerradoCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgCerradoCont.Name = "imgCerradoCont";
            this.imgCerradoCont.Size = new System.Drawing.Size(29, 27);
            this.imgCerradoCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCerradoCont.TabIndex = 32;
            this.imgCerradoCont.TabStop = false;
            this.imgCerradoCont.Visible = false;
            // 
            // imgAbriendoCont
            // 
            this.imgAbriendoCont.Image = ((System.Drawing.Image)(resources.GetObject("imgAbriendoCont.Image")));
            this.imgAbriendoCont.Location = new System.Drawing.Point(479, 572);
            this.imgAbriendoCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgAbriendoCont.Name = "imgAbriendoCont";
            this.imgAbriendoCont.Size = new System.Drawing.Size(29, 27);
            this.imgAbriendoCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAbriendoCont.TabIndex = 33;
            this.imgAbriendoCont.TabStop = false;
            this.imgAbriendoCont.Visible = false;
            // 
            // imgCerrandoCont
            // 
            this.imgCerrandoCont.Image = ((System.Drawing.Image)(resources.GetObject("imgCerrandoCont.Image")));
            this.imgCerrandoCont.Location = new System.Drawing.Point(535, 575);
            this.imgCerrandoCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgCerrandoCont.Name = "imgCerrandoCont";
            this.imgCerrandoCont.Size = new System.Drawing.Size(29, 27);
            this.imgCerrandoCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCerrandoCont.TabIndex = 34;
            this.imgCerrandoCont.TabStop = false;
            this.imgCerrandoCont.Visible = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 617);
            this.ControlBox = false;
            this.Controls.Add(this.imgCerrandoCont);
            this.Controls.Add(this.imgAbriendoCont);
            this.Controls.Add(this.imgCerradoCont);
            this.Controls.Add(this.imgAbiertoCont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pEdicion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pClave.ResumeLayout(false);
            this.pClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOjo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbiertoCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerradoCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbriendoCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrandoCont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pEdicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerEdicion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbFrecuente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtFrecuente;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ComboBox cbComuna;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pClave;
        private System.Windows.Forms.PictureBox btnOjo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox chkClave;
        private System.Windows.Forms.PictureBox imgAbiertoCont;
        private System.Windows.Forms.PictureBox imgCerradoCont;
        private System.Windows.Forms.PictureBox imgAbriendoCont;
        private System.Windows.Forms.PictureBox imgCerrandoCont;
        private System.Windows.Forms.Label lbErrorE;
        private System.Windows.Forms.Label lbErrorR;
        private System.Windows.Forms.Label lbErrorU;
    }
}