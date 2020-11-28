namespace TurismoRealEscritorio.Vistas.Logistica
{
    partial class frmAsignarF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarF));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(425, 341);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 39);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(568, 341);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(119, 39);
            this.btnAplicar.TabIndex = 67;
            this.btnAplicar.Text = "Asignar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(196, 182);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(292, 29);
            this.cbFuncionario.TabIndex = 68;
            this.cbFuncionario.Text = "Seleccione Funcionario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Funcionario:";
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Enabled = false;
            this.btnDesasignar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.Location = new System.Drawing.Point(517, 177);
            this.btnDesasignar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(119, 39);
            this.btnDesasignar.TabIndex = 70;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.lbNombre.Location = new System.Drawing.Point(36, 44);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(190, 48);
            this.lbNombre.TabIndex = 71;
            this.lbNombre.Text = "Localidad";
            // 
            // frmAsignarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 395);
            this.ControlBox = false;
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignarF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Funcionario";
            this.Load += new System.EventHandler(this.frmAsignarF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Label lbNombre;
    }
}