namespace ejercicios
{
    partial class alumnos
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
            this.cboOpcionBuscarAlumnos = new System.Windows.Forms.ComboBox();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.lblBuscarAlumnos = new System.Windows.Forms.Label();
            this.grdDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblnRegistroAlumno = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.erpAlumnos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).BeginInit();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOpcionBuscarAlumnos
            // 
            this.cboOpcionBuscarAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarAlumnos.FormattingEnabled = true;
            this.cboOpcionBuscarAlumnos.Items.AddRange(new object[] {
            "Codigo",
            "Alumno"});
            this.cboOpcionBuscarAlumnos.Location = new System.Drawing.Point(594, 31);
            this.cboOpcionBuscarAlumnos.Name = "cboOpcionBuscarAlumnos";
            this.cboOpcionBuscarAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cboOpcionBuscarAlumnos.TabIndex = 15;
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(721, 31);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(205, 20);
            this.txtBuscarAlumnos.TabIndex = 14;
            this.txtBuscarAlumnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumnos_KeyUp);
            // 
            // lblBuscarAlumnos
            // 
            this.lblBuscarAlumnos.AutoSize = true;
            this.lblBuscarAlumnos.Location = new System.Drawing.Point(534, 34);
            this.lblBuscarAlumnos.Name = "lblBuscarAlumnos";
            this.lblBuscarAlumnos.Size = new System.Drawing.Size(54, 13);
            this.lblBuscarAlumnos.TabIndex = 13;
            this.lblBuscarAlumnos.Text = "BUSCAR:";
            // 
            // grdDatosAlumnos
            // 
            this.grdDatosAlumnos.AllowUserToAddRows = false;
            this.grdDatosAlumnos.AllowUserToDeleteRows = false;
            this.grdDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.DIRECCION,
            this.telefono});
            this.grdDatosAlumnos.Location = new System.Drawing.Point(534, 67);
            this.grdDatosAlumnos.Name = "grdDatosAlumnos";
            this.grdDatosAlumnos.ReadOnly = true;
            this.grdDatosAlumnos.Size = new System.Drawing.Size(402, 279);
            this.grdDatosAlumnos.TabIndex = 12;
            this.grdDatosAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosAlumnos_CellClick);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "direccion";
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Width = 60;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnNuevoAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(247, 255);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(281, 91);
            this.grbEdicionAlumno.TabIndex = 11;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(85, 38);
            this.btnEliminarAlumno.TabIndex = 9;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(88, 33);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(95, 38);
            this.btnModificarAlumno.TabIndex = 8;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoAlumno.TabIndex = 7;
            this.btnNuevoAlumno.Text = "Nuevo";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblnRegistroAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(17, 255);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(224, 91);
            this.grbNavegacionAlumno.TabIndex = 10;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblnRegistroAlumno
            // 
            this.lblnRegistroAlumno.AutoSize = true;
            this.lblnRegistroAlumno.Location = new System.Drawing.Point(75, 47);
            this.lblnRegistroAlumno.Name = "lblnRegistroAlumno";
            this.lblnRegistroAlumno.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistroAlumno.TabIndex = 6;
            this.lblnRegistroAlumno.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(187, 33);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(33, 38);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(156, 33);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(33, 38);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(36, 33);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(33, 38);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(5, 33);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(33, 38);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumno.Location = new System.Drawing.Point(17, 27);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(511, 222);
            this.grbDatosAlumno.TabIndex = 9;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos Alumno";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(97, 178);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.ReadOnly = true;
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(142, 20);
            this.txtTelefonoAlumno.TabIndex = 7;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(15, 181);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(67, 13);
            this.lblTelefonoAlumno.TabIndex = 6;
            this.lblTelefonoAlumno.Text = "TELEFONO:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(97, 127);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.ReadOnly = true;
            this.txtDireccionAlumno.Size = new System.Drawing.Size(391, 20);
            this.txtDireccionAlumno.TabIndex = 5;
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Location = new System.Drawing.Point(13, 130);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(69, 13);
            this.lblDireccionAlumno.TabIndex = 4;
            this.lblDireccionAlumno.Text = "DIRECCION:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(97, 77);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(268, 20);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(25, 84);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(57, 13);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "NOMBRE:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(97, 33);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.ReadOnly = true;
            this.txtCodigoAlumno.Size = new System.Drawing.Size(142, 20);
            this.txtCodigoAlumno.TabIndex = 1;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(30, 40);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(52, 13);
            this.lblCodigoAlumno.TabIndex = 0;
            this.lblCodigoAlumno.Text = "CODIGO:";
            // 
            // erpAlumnos
            // 
            this.erpAlumnos.ContainerControl = this;
            // 
            // alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 380);
            this.Controls.Add(this.cboOpcionBuscarAlumnos);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.lblBuscarAlumnos);
            this.Controls.Add(this.grdDatosAlumnos);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Name = "alumnos";
            this.Text = "Registro de Alumnos";
            this.Load += new System.EventHandler(this.alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).EndInit();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOpcionBuscarAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.Label lblBuscarAlumnos;
        private System.Windows.Forms.DataGridView grdDatosAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Label lblnRegistroAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.ErrorProvider erpAlumnos;
    }
}