namespace ejercicios
{
    partial class inscripcion
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
            System.Windows.Forms.Label idInscripcionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idAlumnoLabel;
            System.Windows.Forms.Label periodoLabel;
            this.idInscripcionTextBox = new System.Windows.Forms.TextBox();
            this.inscripcionMatriculaPeridoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_academicoDataSet = new ejercicios.db_academicoDataSet();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idAlumnoComboBox = new System.Windows.Forms.ComboBox();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoLabel1 = new System.Windows.Forms.Label();
            this.dInscripcionMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dInscripcionMateriaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionInscripcion = new System.Windows.Forms.GroupBox();
            this.btnEliminarInscripcion = new System.Windows.Forms.Button();
            this.btnModificarInscripcion = new System.Windows.Forms.Button();
            this.btnNuevoInscripcion = new System.Windows.Forms.Button();
            this.grbNavegacionInscripcion = new System.Windows.Forms.GroupBox();
            this.lblnRegistroInscripcion = new System.Windows.Forms.Label();
            this.btnUltimoInscripcion = new System.Windows.Forms.Button();
            this.btnSiguienteInscripcion = new System.Windows.Forms.Button();
            this.btnAnteriorInscripcion = new System.Windows.Forms.Button();
            this.btnPrimeroInscripcion = new System.Windows.Forms.Button();
            this.btnAgregarMateriaInscripcion = new System.Windows.Forms.Button();
            this.btnEliminarMateriaInscripcion = new System.Windows.Forms.Button();
            this.inscripcionMatriculaPeridoTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.inscripcionMatriculaPeridoTableAdapter();
            this.tableAdapterManager = new ejercicios.db_academicoDataSetTableAdapters.TableAdapterManager();
            this.alumnosTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.alumnosTableAdapter();
            this.dtDetalleInscripcionMateria = new ejercicios.db_academicoDataSetTableAdapters.dtDetalleInscripcionMateria();
            idInscripcionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idAlumnoLabel = new System.Windows.Forms.Label();
            periodoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionMatriculaPeridoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaDataGridView)).BeginInit();
            this.grbEdicionInscripcion.SuspendLayout();
            this.grbNavegacionInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // idInscripcionLabel
            // 
            idInscripcionLabel.AutoSize = true;
            idInscripcionLabel.Location = new System.Drawing.Point(24, 35);
            idInscripcionLabel.Name = "idInscripcionLabel";
            idInscripcionLabel.Size = new System.Drawing.Size(75, 13);
            idInscripcionLabel.TabIndex = 1;
            idInscripcionLabel.Text = "ID Inscripcion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(24, 66);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Location = new System.Drawing.Point(24, 94);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new System.Drawing.Size(45, 13);
            idAlumnoLabel.TabIndex = 7;
            idAlumnoLabel.Text = "Alumno:";
            // 
            // periodoLabel
            // 
            periodoLabel.AutoSize = true;
            periodoLabel.Location = new System.Drawing.Point(24, 123);
            periodoLabel.Name = "periodoLabel";
            periodoLabel.Size = new System.Drawing.Size(46, 13);
            periodoLabel.TabIndex = 11;
            periodoLabel.Text = "Periodo:";
            // 
            // idInscripcionTextBox
            // 
            this.idInscripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscripcionMatriculaPeridoBindingSource, "idInscripcion", true));
            this.idInscripcionTextBox.Enabled = false;
            this.idInscripcionTextBox.Location = new System.Drawing.Point(102, 32);
            this.idInscripcionTextBox.Name = "idInscripcionTextBox";
            this.idInscripcionTextBox.ReadOnly = true;
            this.idInscripcionTextBox.Size = new System.Drawing.Size(89, 20);
            this.idInscripcionTextBox.TabIndex = 2;
            // 
            // inscripcionMatriculaPeridoBindingSource
            // 
            this.inscripcionMatriculaPeridoBindingSource.DataMember = "inscripcionMatriculaPerido";
            this.inscripcionMatriculaPeridoBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inscripcionMatriculaPeridoBindingSource, "fecha", true));
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(102, 62);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // idAlumnoComboBox
            // 
            this.idAlumnoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscripcionMatriculaPeridoBindingSource, "idAlumno", true));
            this.idAlumnoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inscripcionMatriculaPeridoBindingSource, "idAlumno", true));
            this.idAlumnoComboBox.DataSource = this.alumnosBindingSource;
            this.idAlumnoComboBox.DisplayMember = "nombre";
            this.idAlumnoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idAlumnoComboBox.Enabled = false;
            this.idAlumnoComboBox.FormattingEnabled = true;
            this.idAlumnoComboBox.Location = new System.Drawing.Point(102, 91);
            this.idAlumnoComboBox.Name = "idAlumnoComboBox";
            this.idAlumnoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idAlumnoComboBox.TabIndex = 8;
            this.idAlumnoComboBox.ValueMember = "idAlumno";
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // periodoLabel1
            // 
            this.periodoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscripcionMatriculaPeridoBindingSource, "periodo", true));
            this.periodoLabel1.Location = new System.Drawing.Point(102, 123);
            this.periodoLabel1.Name = "periodoLabel1";
            this.periodoLabel1.Size = new System.Drawing.Size(200, 23);
            this.periodoLabel1.TabIndex = 12;
            this.periodoLabel1.Text = "label1";
            // 
            // dInscripcionMateriaBindingSource
            // 
            this.dInscripcionMateriaBindingSource.DataMember = "inscripcionMatriculaPerido_dInscripcionMateria";
            this.dInscripcionMateriaBindingSource.DataSource = this.inscripcionMatriculaPeridoBindingSource;
            // 
            // dInscripcionMateriaDataGridView
            // 
            this.dInscripcionMateriaDataGridView.AllowUserToAddRows = false;
            this.dInscripcionMateriaDataGridView.AllowUserToDeleteRows = false;
            this.dInscripcionMateriaDataGridView.AutoGenerateColumns = false;
            this.dInscripcionMateriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dInscripcionMateriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.idInscripcion,
            this.idMateria,
            this.codigo,
            this.materia,
            this.uv});
            this.dInscripcionMateriaDataGridView.DataSource = this.dInscripcionMateriaBindingSource;
            this.dInscripcionMateriaDataGridView.Location = new System.Drawing.Point(27, 149);
            this.dInscripcionMateriaDataGridView.Name = "dInscripcionMateriaDataGridView";
            this.dInscripcionMateriaDataGridView.ReadOnly = true;
            this.dInscripcionMateriaDataGridView.Size = new System.Drawing.Size(448, 220);
            this.dInscripcionMateriaDataGridView.TabIndex = 12;
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // idInscripcion
            // 
            this.idInscripcion.DataPropertyName = "idInscripcion";
            this.idInscripcion.HeaderText = "ID";
            this.idInscripcion.Name = "idInscripcion";
            this.idInscripcion.ReadOnly = true;
            this.idInscripcion.Width = 50;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "idMateria";
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
            // materia
            // 
            this.materia.DataPropertyName = "materia";
            this.materia.HeaderText = "MATERIA";
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            this.materia.Width = 200;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            this.uv.Width = 50;
            // 
            // grbEdicionInscripcion
            // 
            this.grbEdicionInscripcion.Controls.Add(this.btnEliminarInscripcion);
            this.grbEdicionInscripcion.Controls.Add(this.btnModificarInscripcion);
            this.grbEdicionInscripcion.Controls.Add(this.btnNuevoInscripcion);
            this.grbEdicionInscripcion.Location = new System.Drawing.Point(258, 385);
            this.grbEdicionInscripcion.Name = "grbEdicionInscripcion";
            this.grbEdicionInscripcion.Size = new System.Drawing.Size(311, 91);
            this.grbEdicionInscripcion.TabIndex = 15;
            this.grbEdicionInscripcion.TabStop = false;
            this.grbEdicionInscripcion.Text = "Edicion";
            // 
            // btnEliminarInscripcion
            // 
            this.btnEliminarInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInscripcion.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarInscripcion.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarInscripcion.Name = "btnEliminarInscripcion";
            this.btnEliminarInscripcion.Size = new System.Drawing.Size(85, 38);
            this.btnEliminarInscripcion.TabIndex = 9;
            this.btnEliminarInscripcion.Text = "Eliminar";
            this.btnEliminarInscripcion.UseVisualStyleBackColor = true;
            // 
            // btnModificarInscripcion
            // 
            this.btnModificarInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInscripcion.Location = new System.Drawing.Point(88, 33);
            this.btnModificarInscripcion.Name = "btnModificarInscripcion";
            this.btnModificarInscripcion.Size = new System.Drawing.Size(95, 38);
            this.btnModificarInscripcion.TabIndex = 8;
            this.btnModificarInscripcion.Text = "Modificar";
            this.btnModificarInscripcion.UseVisualStyleBackColor = true;
            this.btnModificarInscripcion.Click += new System.EventHandler(this.btnModificarInscripcion_Click);
            // 
            // btnNuevoInscripcion
            // 
            this.btnNuevoInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoInscripcion.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoInscripcion.Name = "btnNuevoInscripcion";
            this.btnNuevoInscripcion.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoInscripcion.TabIndex = 7;
            this.btnNuevoInscripcion.Text = "Nuevo";
            this.btnNuevoInscripcion.UseVisualStyleBackColor = true;
            this.btnNuevoInscripcion.Click += new System.EventHandler(this.btnNuevoInscripcion_Click);
            // 
            // grbNavegacionInscripcion
            // 
            this.grbNavegacionInscripcion.Controls.Add(this.lblnRegistroInscripcion);
            this.grbNavegacionInscripcion.Controls.Add(this.btnUltimoInscripcion);
            this.grbNavegacionInscripcion.Controls.Add(this.btnSiguienteInscripcion);
            this.grbNavegacionInscripcion.Controls.Add(this.btnAnteriorInscripcion);
            this.grbNavegacionInscripcion.Controls.Add(this.btnPrimeroInscripcion);
            this.grbNavegacionInscripcion.Location = new System.Drawing.Point(28, 385);
            this.grbNavegacionInscripcion.Name = "grbNavegacionInscripcion";
            this.grbNavegacionInscripcion.Size = new System.Drawing.Size(224, 91);
            this.grbNavegacionInscripcion.TabIndex = 14;
            this.grbNavegacionInscripcion.TabStop = false;
            this.grbNavegacionInscripcion.Text = "Navegacion";
            // 
            // lblnRegistroInscripcion
            // 
            this.lblnRegistroInscripcion.AutoSize = true;
            this.lblnRegistroInscripcion.Location = new System.Drawing.Point(75, 47);
            this.lblnRegistroInscripcion.Name = "lblnRegistroInscripcion";
            this.lblnRegistroInscripcion.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistroInscripcion.TabIndex = 6;
            this.lblnRegistroInscripcion.Text = "x de n";
            // 
            // btnUltimoInscripcion
            // 
            this.btnUltimoInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoInscripcion.Location = new System.Drawing.Point(187, 33);
            this.btnUltimoInscripcion.Name = "btnUltimoInscripcion";
            this.btnUltimoInscripcion.Size = new System.Drawing.Size(33, 38);
            this.btnUltimoInscripcion.TabIndex = 3;
            this.btnUltimoInscripcion.Text = ">|";
            this.btnUltimoInscripcion.UseVisualStyleBackColor = true;
            this.btnUltimoInscripcion.Click += new System.EventHandler(this.btnUltimoInscripcion_Click);
            // 
            // btnSiguienteInscripcion
            // 
            this.btnSiguienteInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteInscripcion.Location = new System.Drawing.Point(156, 33);
            this.btnSiguienteInscripcion.Name = "btnSiguienteInscripcion";
            this.btnSiguienteInscripcion.Size = new System.Drawing.Size(33, 38);
            this.btnSiguienteInscripcion.TabIndex = 2;
            this.btnSiguienteInscripcion.Text = ">";
            this.btnSiguienteInscripcion.UseVisualStyleBackColor = true;
            this.btnSiguienteInscripcion.Click += new System.EventHandler(this.btnSiguienteInscripcion_Click);
            // 
            // btnAnteriorInscripcion
            // 
            this.btnAnteriorInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorInscripcion.Location = new System.Drawing.Point(36, 33);
            this.btnAnteriorInscripcion.Name = "btnAnteriorInscripcion";
            this.btnAnteriorInscripcion.Size = new System.Drawing.Size(33, 38);
            this.btnAnteriorInscripcion.TabIndex = 1;
            this.btnAnteriorInscripcion.Text = "<";
            this.btnAnteriorInscripcion.UseVisualStyleBackColor = true;
            this.btnAnteriorInscripcion.Click += new System.EventHandler(this.btnAnteriorInscripcion_Click);
            // 
            // btnPrimeroInscripcion
            // 
            this.btnPrimeroInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroInscripcion.Location = new System.Drawing.Point(5, 33);
            this.btnPrimeroInscripcion.Name = "btnPrimeroInscripcion";
            this.btnPrimeroInscripcion.Size = new System.Drawing.Size(33, 38);
            this.btnPrimeroInscripcion.TabIndex = 0;
            this.btnPrimeroInscripcion.Text = "|<";
            this.btnPrimeroInscripcion.UseVisualStyleBackColor = true;
            this.btnPrimeroInscripcion.Click += new System.EventHandler(this.btnPrimeroInscripcion_Click);
            // 
            // btnAgregarMateriaInscripcion
            // 
            this.btnAgregarMateriaInscripcion.Enabled = false;
            this.btnAgregarMateriaInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateriaInscripcion.Location = new System.Drawing.Point(481, 149);
            this.btnAgregarMateriaInscripcion.Name = "btnAgregarMateriaInscripcion";
            this.btnAgregarMateriaInscripcion.Size = new System.Drawing.Size(88, 99);
            this.btnAgregarMateriaInscripcion.TabIndex = 10;
            this.btnAgregarMateriaInscripcion.Text = "Agregar Materia";
            this.btnAgregarMateriaInscripcion.UseVisualStyleBackColor = true;
            this.btnAgregarMateriaInscripcion.Click += new System.EventHandler(this.btnAgregarMateriaInscripcion_Click);
            // 
            // btnEliminarMateriaInscripcion
            // 
            this.btnEliminarMateriaInscripcion.Enabled = false;
            this.btnEliminarMateriaInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateriaInscripcion.Location = new System.Drawing.Point(481, 267);
            this.btnEliminarMateriaInscripcion.Name = "btnEliminarMateriaInscripcion";
            this.btnEliminarMateriaInscripcion.Size = new System.Drawing.Size(88, 102);
            this.btnEliminarMateriaInscripcion.TabIndex = 16;
            this.btnEliminarMateriaInscripcion.Text = "Eliminar Materia";
            this.btnEliminarMateriaInscripcion.UseVisualStyleBackColor = true;
            this.btnEliminarMateriaInscripcion.Click += new System.EventHandler(this.btnEliminarMateriaInscripcion_Click);
            // 
            // inscripcionMatriculaPeridoTableAdapter
            // 
            this.inscripcionMatriculaPeridoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.matriculaTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = null;
            this.tableAdapterManager.periodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ejercicios.db_academicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // dtDetalleInscripcionMateria
            // 
            this.dtDetalleInscripcionMateria.ClearBeforeFill = true;
            // 
            // inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 513);
            this.Controls.Add(this.btnEliminarMateriaInscripcion);
            this.Controls.Add(this.btnAgregarMateriaInscripcion);
            this.Controls.Add(this.grbEdicionInscripcion);
            this.Controls.Add(this.grbNavegacionInscripcion);
            this.Controls.Add(this.dInscripcionMateriaDataGridView);
            this.Controls.Add(idInscripcionLabel);
            this.Controls.Add(this.idInscripcionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idAlumnoLabel);
            this.Controls.Add(this.idAlumnoComboBox);
            this.Controls.Add(periodoLabel);
            this.Controls.Add(this.periodoLabel1);
            this.Name = "inscripcion";
            this.Text = "inscripcion";
            this.Load += new System.EventHandler(this.inscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionMatriculaPeridoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaDataGridView)).EndInit();
            this.grbEdicionInscripcion.ResumeLayout(false);
            this.grbNavegacionInscripcion.ResumeLayout(false);
            this.grbNavegacionInscripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicoDataSet db_academicoDataSet;
        private System.Windows.Forms.BindingSource inscripcionMatriculaPeridoBindingSource;
        private db_academicoDataSetTableAdapters.inscripcionMatriculaPeridoTableAdapter inscripcionMatriculaPeridoTableAdapter;
        private db_academicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idInscripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox idAlumnoComboBox;
        private System.Windows.Forms.Label periodoLabel1;
        private db_academicoDataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private System.Windows.Forms.BindingSource dInscripcionMateriaBindingSource;
        private db_academicoDataSetTableAdapters.dtDetalleInscripcionMateria dtDetalleInscripcionMateria;
        private System.Windows.Forms.DataGridView dInscripcionMateriaDataGridView;
        private System.Windows.Forms.GroupBox grbEdicionInscripcion;
        private System.Windows.Forms.Button btnEliminarInscripcion;
        private System.Windows.Forms.Button btnModificarInscripcion;
        private System.Windows.Forms.Button btnNuevoInscripcion;
        private System.Windows.Forms.GroupBox grbNavegacionInscripcion;
        private System.Windows.Forms.Label lblnRegistroInscripcion;
        private System.Windows.Forms.Button btnUltimoInscripcion;
        private System.Windows.Forms.Button btnSiguienteInscripcion;
        private System.Windows.Forms.Button btnAnteriorInscripcion;
        private System.Windows.Forms.Button btnPrimeroInscripcion;
        private System.Windows.Forms.Button btnAgregarMateriaInscripcion;
        private System.Windows.Forms.Button btnEliminarMateriaInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}