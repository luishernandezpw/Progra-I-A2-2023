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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblNTablaMultiplicar = new System.Windows.Forms.Label();
            this.txtNTablaMultiplicar = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(84, 133);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(138, 68);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblNTablaMultiplicar
            // 
            this.lblNTablaMultiplicar.AutoSize = true;
            this.lblNTablaMultiplicar.Location = new System.Drawing.Point(29, 44);
            this.lblNTablaMultiplicar.Name = "lblNTablaMultiplicar";
            this.lblNTablaMultiplicar.Size = new System.Drawing.Size(87, 13);
            this.lblNTablaMultiplicar.TabIndex = 1;
            this.lblNTablaMultiplicar.Text = "Tabla Multiplicar:";
            // 
            // txtNTablaMultiplicar
            // 
            this.txtNTablaMultiplicar.Location = new System.Drawing.Point(122, 41);
            this.txtNTablaMultiplicar.Name = "txtNTablaMultiplicar";
            this.txtNTablaMultiplicar.Size = new System.Drawing.Size(100, 20);
            this.txtNTablaMultiplicar.TabIndex = 2;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(241, 44);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(41, 13);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Num 1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(288, 41);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(44, 20);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(385, 41);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(44, 20);
            this.txtNum2.TabIndex = 6;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(338, 44);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(41, 13);
            this.lblNum2.TabIndex = 5;
            this.lblNum2.Text = "Num 2:";
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(264, 133);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(138, 68);
            this.btnSumar.TabIndex = 7;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 250);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNTablaMultiplicar);
            this.Controls.Add(this.lblNTablaMultiplicar);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblNTablaMultiplicar;
        private System.Windows.Forms.TextBox txtNTablaMultiplicar;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnSumar;
    }
}

