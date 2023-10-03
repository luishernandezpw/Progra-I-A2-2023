
namespace ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblnRegistroMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnNuevoMateria = new System.Windows.Forms.Button();
            this.grdDatosMaterias = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.lblBuscarMaterias = new System.Windows.Forms.Label();
            this.grbDatosMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbEdicionMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Location = new System.Drawing.Point(12, 31);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Size = new System.Drawing.Size(511, 185);
            this.grbDatosMateria.TabIndex = 0;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos Materia";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(88, 123);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.ReadOnly = true;
            this.txtUvMateria.Size = new System.Drawing.Size(63, 20);
            this.txtUvMateria.TabIndex = 5;
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Location = new System.Drawing.Point(57, 130);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(25, 13);
            this.lblUvMateria.TabIndex = 4;
            this.lblUvMateria.Text = "UV:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(88, 77);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.ReadOnly = true;
            this.txtNombreMateria.Size = new System.Drawing.Size(268, 20);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(24, 84);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(58, 13);
            this.lblNombreMateria.TabIndex = 2;
            this.lblNombreMateria.Text = "MATERIA:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(88, 33);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.ReadOnly = true;
            this.txtCodigoMateria.Size = new System.Drawing.Size(142, 20);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Location = new System.Drawing.Point(30, 40);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(52, 13);
            this.lblCodigoMateria.TabIndex = 0;
            this.lblCodigoMateria.Text = "CODIGO:";
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblnRegistroMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(12, 259);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Size = new System.Drawing.Size(224, 91);
            this.grbNavegacionMateria.TabIndex = 1;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblnRegistroMateria
            // 
            this.lblnRegistroMateria.AutoSize = true;
            this.lblnRegistroMateria.Location = new System.Drawing.Point(75, 47);
            this.lblnRegistroMateria.Name = "lblnRegistroMateria";
            this.lblnRegistroMateria.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistroMateria.TabIndex = 6;
            this.lblnRegistroMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(187, 33);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(33, 38);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(156, 33);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(33, 38);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(36, 33);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(33, 38);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(5, 33);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(33, 38);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnNuevoMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(242, 259);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Size = new System.Drawing.Size(281, 91);
            this.grbEdicionMateria.TabIndex = 2;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarMateria.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(85, 38);
            this.btnEliminarMateria.TabIndex = 9;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(88, 33);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(95, 38);
            this.btnModificarMateria.TabIndex = 8;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnNuevoMateria
            // 
            this.btnNuevoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMateria.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoMateria.Name = "btnNuevoMateria";
            this.btnNuevoMateria.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoMateria.TabIndex = 7;
            this.btnNuevoMateria.Text = "Nuevo";
            this.btnNuevoMateria.UseVisualStyleBackColor = true;
            this.btnNuevoMateria.Click += new System.EventHandler(this.btnNuevoMateria_Click);
            // 
            // grdDatosMaterias
            // 
            this.grdDatosMaterias.AllowUserToAddRows = false;
            this.grdDatosMaterias.AllowUserToDeleteRows = false;
            this.grdDatosMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosMaterias.Location = new System.Drawing.Point(529, 71);
            this.grdDatosMaterias.Name = "grdDatosMaterias";
            this.grdDatosMaterias.ReadOnly = true;
            this.grdDatosMaterias.Size = new System.Drawing.Size(383, 279);
            this.grdDatosMaterias.TabIndex = 3;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "ID";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
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
            this.nombre.DataPropertyName = "materia";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            this.uv.Width = 60;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(593, 31);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(319, 20);
            this.txtBuscarMaterias.TabIndex = 7;
            // 
            // lblBuscarMaterias
            // 
            this.lblBuscarMaterias.AutoSize = true;
            this.lblBuscarMaterias.Location = new System.Drawing.Point(535, 38);
            this.lblBuscarMaterias.Name = "lblBuscarMaterias";
            this.lblBuscarMaterias.Size = new System.Drawing.Size(54, 13);
            this.lblBuscarMaterias.TabIndex = 6;
            this.lblBuscarMaterias.Text = "BUSCAR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 370);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.lblBuscarMaterias);
            this.Controls.Add(this.grdDatosMaterias);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "Form1";
            this.Text = "Registro de Materias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbEdicionMateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.Label lblnRegistroMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnNuevoMateria;
        private System.Windows.Forms.DataGridView grdDatosMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.Label lblBuscarMaterias;
    }
}

