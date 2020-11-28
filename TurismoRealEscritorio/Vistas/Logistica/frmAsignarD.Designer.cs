namespace TurismoRealEscritorio.Vistas.Logistica
{
    partial class frmAsignarD
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.cbDeptos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.lbNombre.Location = new System.Drawing.Point(26, 29);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(160, 48);
            this.lbNombre.TabIndex = 77;
            this.lbNombre.Text = "Articulo";
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Enabled = false;
            this.btnDesasignar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.Location = new System.Drawing.Point(558, 180);
            this.btnDesasignar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(119, 39);
            this.btnDesasignar.TabIndex = 76;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(520, 333);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 39);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(663, 333);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(119, 39);
            this.btnAplicar.TabIndex = 73;
            this.btnAplicar.Text = "Asignar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // cbDeptos
            // 
            this.cbDeptos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.cbDeptos.FormattingEnabled = true;
            this.cbDeptos.Location = new System.Drawing.Point(205, 185);
            this.cbDeptos.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeptos.Name = "cbDeptos";
            this.cbDeptos.Size = new System.Drawing.Size(308, 29);
            this.cbDeptos.TabIndex = 74;
            this.cbDeptos.Text = "Seleccione Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 72;
            this.label8.Text = "Departamento:";
            // 
            // frmAsignarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 395);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cbDeptos);
            this.Controls.Add(this.label8);
            this.Name = "frmAsignarD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsignarD";
            this.Load += new System.EventHandler(this.frmAsignarD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ComboBox cbDeptos;
        private System.Windows.Forms.Label label8;
    }
}