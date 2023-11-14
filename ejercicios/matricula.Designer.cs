namespace ejercicios
{
    partial class matricula
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
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_academicoDataSet = new ejercicios.db_academicoDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodosTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.periodosTableAdapter();
            this.alumnosTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.alumnosTableAdapter();
            this.grbEdicionMatricula = new System.Windows.Forms.GroupBox();
            this.btnEliminarMatricula = new System.Windows.Forms.Button();
            this.btnModificarMatricula = new System.Windows.Forms.Button();
            this.btnNuevoMatricula = new System.Windows.Forms.Button();
            this.grbNavegacionMatricula = new System.Windows.Forms.GroupBox();
            this.lblnRegistroMatricula = new System.Windows.Forms.Label();
            this.btnUltimoMatricula = new System.Windows.Forms.Button();
            this.btnSiguienteMatricula = new System.Windows.Forms.Button();
            this.btnAnteriorMatricula = new System.Windows.Forms.Button();
            this.btnPrimeroMatricula = new System.Windows.Forms.Button();
            this.matriculaTableAdapter1 = new ejercicios.db_academicoDataSetTableAdapters.matriculaTableAdapter();
            this.tableAdapterManager = new ejercicios.db_academicoDataSetTableAdapters.TableAdapterManager();
            this.matriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPeriodoMatricula = new System.Windows.Forms.ComboBox();
            this.cboAlumnoMatricula = new System.Windows.Forms.ComboBox();
            this.lblPeriodoMatricula = new System.Windows.Forms.Label();
            this.lblAlumnoMatricula = new System.Windows.Forms.Label();
            this.lblFechaMatricula = new System.Windows.Forms.Label();
            this.dtFechaMatriucla = new System.Windows.Forms.DateTimePicker();
            this.matriculaAlumnosPeriodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtMatriculaAlumnosPeriodos = new ejercicios.db_academicoDataSetTableAdapters.dtMatriculaAlumnosPeriodos();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.grbEdicionMatricula.SuspendLayout();
            this.grbNavegacionMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaAlumnosPeriodosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "periodos";
            this.periodosBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // grbEdicionMatricula
            // 
            this.grbEdicionMatricula.Controls.Add(this.btnEliminarMatricula);
            this.grbEdicionMatricula.Controls.Add(this.btnModificarMatricula);
            this.grbEdicionMatricula.Controls.Add(this.btnNuevoMatricula);
            this.grbEdicionMatricula.Location = new System.Drawing.Point(262, 286);
            this.grbEdicionMatricula.Name = "grbEdicionMatricula";
            this.grbEdicionMatricula.Size = new System.Drawing.Size(281, 91);
            this.grbEdicionMatricula.TabIndex = 13;
            this.grbEdicionMatricula.TabStop = false;
            this.grbEdicionMatricula.Text = "Edicion";
            // 
            // btnEliminarMatricula
            // 
            this.btnEliminarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMatricula.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarMatricula.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarMatricula.Name = "btnEliminarMatricula";
            this.btnEliminarMatricula.Size = new System.Drawing.Size(85, 38);
            this.btnEliminarMatricula.TabIndex = 9;
            this.btnEliminarMatricula.Text = "Eliminar";
            this.btnEliminarMatricula.UseVisualStyleBackColor = true;
            // 
            // btnModificarMatricula
            // 
            this.btnModificarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMatricula.Location = new System.Drawing.Point(88, 33);
            this.btnModificarMatricula.Name = "btnModificarMatricula";
            this.btnModificarMatricula.Size = new System.Drawing.Size(95, 38);
            this.btnModificarMatricula.TabIndex = 8;
            this.btnModificarMatricula.Text = "Modificar";
            this.btnModificarMatricula.UseVisualStyleBackColor = true;
            // 
            // btnNuevoMatricula
            // 
            this.btnNuevoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMatricula.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoMatricula.Name = "btnNuevoMatricula";
            this.btnNuevoMatricula.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoMatricula.TabIndex = 7;
            this.btnNuevoMatricula.Text = "Nuevo";
            this.btnNuevoMatricula.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionMatricula
            // 
            this.grbNavegacionMatricula.Controls.Add(this.lblnRegistroMatricula);
            this.grbNavegacionMatricula.Controls.Add(this.btnUltimoMatricula);
            this.grbNavegacionMatricula.Controls.Add(this.btnSiguienteMatricula);
            this.grbNavegacionMatricula.Controls.Add(this.btnAnteriorMatricula);
            this.grbNavegacionMatricula.Controls.Add(this.btnPrimeroMatricula);
            this.grbNavegacionMatricula.Location = new System.Drawing.Point(32, 286);
            this.grbNavegacionMatricula.Name = "grbNavegacionMatricula";
            this.grbNavegacionMatricula.Size = new System.Drawing.Size(224, 91);
            this.grbNavegacionMatricula.TabIndex = 12;
            this.grbNavegacionMatricula.TabStop = false;
            this.grbNavegacionMatricula.Text = "Navegacion";
            // 
            // lblnRegistroMatricula
            // 
            this.lblnRegistroMatricula.AutoSize = true;
            this.lblnRegistroMatricula.Location = new System.Drawing.Point(75, 47);
            this.lblnRegistroMatricula.Name = "lblnRegistroMatricula";
            this.lblnRegistroMatricula.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistroMatricula.TabIndex = 6;
            this.lblnRegistroMatricula.Text = "x de n";
            // 
            // btnUltimoMatricula
            // 
            this.btnUltimoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMatricula.Location = new System.Drawing.Point(187, 33);
            this.btnUltimoMatricula.Name = "btnUltimoMatricula";
            this.btnUltimoMatricula.Size = new System.Drawing.Size(33, 38);
            this.btnUltimoMatricula.TabIndex = 3;
            this.btnUltimoMatricula.Text = ">|";
            this.btnUltimoMatricula.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteMatricula
            // 
            this.btnSiguienteMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMatricula.Location = new System.Drawing.Point(156, 33);
            this.btnSiguienteMatricula.Name = "btnSiguienteMatricula";
            this.btnSiguienteMatricula.Size = new System.Drawing.Size(33, 38);
            this.btnSiguienteMatricula.TabIndex = 2;
            this.btnSiguienteMatricula.Text = ">";
            this.btnSiguienteMatricula.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorMatricula
            // 
            this.btnAnteriorMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMatricula.Location = new System.Drawing.Point(36, 33);
            this.btnAnteriorMatricula.Name = "btnAnteriorMatricula";
            this.btnAnteriorMatricula.Size = new System.Drawing.Size(33, 38);
            this.btnAnteriorMatricula.TabIndex = 1;
            this.btnAnteriorMatricula.Text = "<";
            this.btnAnteriorMatricula.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroMatricula
            // 
            this.btnPrimeroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMatricula.Location = new System.Drawing.Point(5, 33);
            this.btnPrimeroMatricula.Name = "btnPrimeroMatricula";
            this.btnPrimeroMatricula.Size = new System.Drawing.Size(33, 38);
            this.btnPrimeroMatricula.TabIndex = 0;
            this.btnPrimeroMatricula.Text = "|<";
            this.btnPrimeroMatricula.UseVisualStyleBackColor = true;
            // 
            // matriculaTableAdapter1
            // 
            this.matriculaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_inscripcionTableAdapter = null;
            this.tableAdapterManager.detalle_notasTableAdapter = null;
            this.tableAdapterManager.docentesTableAdapter = null;
            this.tableAdapterManager.inscripcionTableAdapter = null;
            this.tableAdapterManager.materiasTableAdapter = null;
            this.tableAdapterManager.matriculaTableAdapter = this.matriculaTableAdapter1;
            this.tableAdapterManager.notasTableAdapter = null;
            this.tableAdapterManager.periodosTableAdapter = this.periodosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ejercicios.db_academicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // matriculaBindingSource
            // 
            this.matriculaBindingSource.DataMember = "matricula";
            this.matriculaBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // cboPeriodoMatricula
            // 
            this.cboPeriodoMatricula.DataSource = this.periodosBindingSource;
            this.cboPeriodoMatricula.DisplayMember = "periodo";
            this.cboPeriodoMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodoMatricula.FormattingEnabled = true;
            this.cboPeriodoMatricula.Location = new System.Drawing.Point(81, 34);
            this.cboPeriodoMatricula.Name = "cboPeriodoMatricula";
            this.cboPeriodoMatricula.Size = new System.Drawing.Size(223, 21);
            this.cboPeriodoMatricula.TabIndex = 0;
            this.cboPeriodoMatricula.ValueMember = "idPeriodo";
            // 
            // cboAlumnoMatricula
            // 
            this.cboAlumnoMatricula.DataSource = this.alumnosBindingSource;
            this.cboAlumnoMatricula.DisplayMember = "nombre";
            this.cboAlumnoMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnoMatricula.FormattingEnabled = true;
            this.cboAlumnoMatricula.Location = new System.Drawing.Point(81, 93);
            this.cboAlumnoMatricula.Name = "cboAlumnoMatricula";
            this.cboAlumnoMatricula.Size = new System.Drawing.Size(223, 21);
            this.cboAlumnoMatricula.TabIndex = 1;
            this.cboAlumnoMatricula.ValueMember = "idAlumno";
            // 
            // lblPeriodoMatricula
            // 
            this.lblPeriodoMatricula.AutoSize = true;
            this.lblPeriodoMatricula.Location = new System.Drawing.Point(29, 37);
            this.lblPeriodoMatricula.Name = "lblPeriodoMatricula";
            this.lblPeriodoMatricula.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodoMatricula.TabIndex = 2;
            this.lblPeriodoMatricula.Text = "Periodo:";
            // 
            // lblAlumnoMatricula
            // 
            this.lblAlumnoMatricula.AutoSize = true;
            this.lblAlumnoMatricula.Location = new System.Drawing.Point(29, 93);
            this.lblAlumnoMatricula.Name = "lblAlumnoMatricula";
            this.lblAlumnoMatricula.Size = new System.Drawing.Size(45, 13);
            this.lblAlumnoMatricula.TabIndex = 3;
            this.lblAlumnoMatricula.Text = "Alumno:";
            // 
            // lblFechaMatricula
            // 
            this.lblFechaMatricula.AutoSize = true;
            this.lblFechaMatricula.Location = new System.Drawing.Point(29, 153);
            this.lblFechaMatricula.Name = "lblFechaMatricula";
            this.lblFechaMatricula.Size = new System.Drawing.Size(40, 13);
            this.lblFechaMatricula.TabIndex = 4;
            this.lblFechaMatricula.Text = "Fecha:";
            // 
            // dtFechaMatriucla
            // 
            this.dtFechaMatriucla.Location = new System.Drawing.Point(81, 153);
            this.dtFechaMatriucla.Name = "dtFechaMatriucla";
            this.dtFechaMatriucla.Size = new System.Drawing.Size(223, 20);
            this.dtFechaMatriucla.TabIndex = 5;
            // 
            // matriculaAlumnosPeriodosBindingSource
            // 
            this.matriculaAlumnosPeriodosBindingSource.DataMember = "matriculaAlumnosPeriodos";
            this.matriculaAlumnosPeriodosBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // dtMatriculaAlumnosPeriodos
            // 
            this.dtMatriculaAlumnosPeriodos.ClearBeforeFill = true;
            // 
            // matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 398);
            this.Controls.Add(this.grbEdicionMatricula);
            this.Controls.Add(this.grbNavegacionMatricula);
            this.Controls.Add(this.dtFechaMatriucla);
            this.Controls.Add(this.lblFechaMatricula);
            this.Controls.Add(this.lblAlumnoMatricula);
            this.Controls.Add(this.lblPeriodoMatricula);
            this.Controls.Add(this.cboAlumnoMatricula);
            this.Controls.Add(this.cboPeriodoMatricula);
            this.Name = "matricula";
            this.Text = "Registro de Matriculas";
            this.Load += new System.EventHandler(this.matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.grbEdicionMatricula.ResumeLayout(false);
            this.grbNavegacionMatricula.ResumeLayout(false);
            this.grbNavegacionMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaAlumnosPeriodosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private db_academicoDataSet db_academicoDataSet;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private db_academicoDataSetTableAdapters.periodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private db_academicoDataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.GroupBox grbEdicionMatricula;
        private System.Windows.Forms.Button btnEliminarMatricula;
        private System.Windows.Forms.Button btnModificarMatricula;
        private System.Windows.Forms.Button btnNuevoMatricula;
        private System.Windows.Forms.GroupBox grbNavegacionMatricula;
        private System.Windows.Forms.Label lblnRegistroMatricula;
        private System.Windows.Forms.Button btnUltimoMatricula;
        private System.Windows.Forms.Button btnSiguienteMatricula;
        private System.Windows.Forms.Button btnAnteriorMatricula;
        private System.Windows.Forms.Button btnPrimeroMatricula;
        private db_academicoDataSetTableAdapters.matriculaTableAdapter matriculaTableAdapter1;
        private db_academicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource matriculaBindingSource;
        private System.Windows.Forms.ComboBox cboPeriodoMatricula;
        private System.Windows.Forms.ComboBox cboAlumnoMatricula;
        private System.Windows.Forms.Label lblPeriodoMatricula;
        private System.Windows.Forms.Label lblAlumnoMatricula;
        private System.Windows.Forms.Label lblFechaMatricula;
        private System.Windows.Forms.DateTimePicker dtFechaMatriucla;
        private System.Windows.Forms.BindingSource matriculaAlumnosPeriodosBindingSource;
        private db_academicoDataSetTableAdapters.dtMatriculaAlumnosPeriodos dtMatriculaAlumnosPeriodos;
    }
}