namespace SchoolDB.Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProgramacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudProgramacion = new System.Windows.Forms.NumericUpDown();
            this.nudContabilidad = new System.Windows.Forms.NumericUpDown();
            this.nudEstadistica = new System.Windows.Forms.NumericUpDown();
            this.nudMatematicas = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(843, 107);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 39);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(43, 99);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(73, 20);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Nombres:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(43, 149);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellidos:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(43, 200);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(55, 20);
            this.lblCarnet.TabIndex = 3;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(43, 248);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(61, 20);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(31, 352);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(43, 300);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(113, 348);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(159, 51);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 296);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(159, 27);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(113, 248);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(159, 27);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(113, 197);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(159, 27);
            this.txtCarnet.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(117, 144);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 27);
            this.txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 99);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 27);
            this.txtNombre.TabIndex = 12;
            // 
            // lblProgramacion
            // 
            this.lblProgramacion.AutoSize = true;
            this.lblProgramacion.Location = new System.Drawing.Point(448, 109);
            this.lblProgramacion.Name = "lblProgramacion";
            this.lblProgramacion.Size = new System.Drawing.Size(105, 20);
            this.lblProgramacion.TabIndex = 13;
            this.lblProgramacion.Text = "Programacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registro de estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Registro de notas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Contabilidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estadistica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Matematicas:";
            // 
            // nudProgramacion
            // 
            this.nudProgramacion.Location = new System.Drawing.Point(574, 107);
            this.nudProgramacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudProgramacion.Name = "nudProgramacion";
            this.nudProgramacion.Size = new System.Drawing.Size(137, 27);
            this.nudProgramacion.TabIndex = 19;
            // 
            // nudContabilidad
            // 
            this.nudContabilidad.Location = new System.Drawing.Point(574, 171);
            this.nudContabilidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudContabilidad.Name = "nudContabilidad";
            this.nudContabilidad.Size = new System.Drawing.Size(137, 27);
            this.nudContabilidad.TabIndex = 20;
            // 
            // nudEstadistica
            // 
            this.nudEstadistica.Location = new System.Drawing.Point(574, 233);
            this.nudEstadistica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudEstadistica.Name = "nudEstadistica";
            this.nudEstadistica.Size = new System.Drawing.Size(137, 27);
            this.nudEstadistica.TabIndex = 21;
            // 
            // nudMatematicas
            // 
            this.nudMatematicas.Location = new System.Drawing.Point(574, 301);
            this.nudMatematicas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudMatematicas.Name = "nudMatematicas";
            this.nudMatematicas.Size = new System.Drawing.Size(137, 27);
            this.nudMatematicas.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(843, 181);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 39);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(843, 248);
            this.btnPromedio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(86, 44);
            this.btnPromedio.TabIndex = 24;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(1, 431);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 25;
            this.dgvStudent.Size = new System.Drawing.Size(1034, 321);
            this.dgvStudent.TabIndex = 25;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(846, 320);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 41);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 756);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudMatematicas);
            this.Controls.Add(this.nudEstadistica);
            this.Controls.Add(this.nudContabilidad);
            this.Controls.Add(this.nudProgramacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProgramacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProgramacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudProgramacion;
        private System.Windows.Forms.NumericUpDown nudContabilidad;
        private System.Windows.Forms.NumericUpDown nudEstadistica;
        private System.Windows.Forms.NumericUpDown nudMatematicas;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnDelete;
    }
}
