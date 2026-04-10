namespace Camiones
{
    partial class NuevaCapacitacion
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
            components = new System.ComponentModel.Container();
            btnCapacitacion = new Button();
            label4 = new Label();
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            txtObservaciones = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cmbOperador = new ComboBox();
            cmbTema = new ComboBox();
            txtIdCapacitacion = new TextBox();
            label3 = new Label();
            txtRutaEvidencia = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            chkActivo = new CheckBox();
            btnSubirEvidencia = new Button();
            btnLimpiar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(764, 386);
            // 
            // btnCapacitacion
            // 
            btnCapacitacion.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapacitacion.Location = new Point(419, 383);
            btnCapacitacion.Name = "btnCapacitacion";
            btnCapacitacion.Size = new Size(140, 61);
            btnCapacitacion.TabIndex = 3;
            btnCapacitacion.Text = "Guardar";
            btnCapacitacion.UseVisualStyleBackColor = true;
            btnCapacitacion.Click += btnCapacitacion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 157);
            label4.Name = "label4";
            label4.Size = new Size(180, 19);
            label4.TabIndex = 9;
            label4.Text = "Fecha de capacitacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(499, 92);
            label5.Name = "label5";
            label5.Size = new Size(124, 19);
            label5.TabIndex = 10;
            label5.Text = "Observaciones";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(274, 157);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 11;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(668, 92);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(182, 134);
            txtObservaciones.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 78);
            label6.Name = "label6";
            label6.Size = new Size(177, 19);
            label6.TabIndex = 13;
            label6.Text = "Tema de Capacitacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 29);
            label7.Name = "label7";
            label7.Size = new Size(173, 19);
            label7.TabIndex = 14;
            label7.Text = "Nombre del Operador";
            // 
            // cmbOperador
            // 
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Location = new Point(319, 26);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(121, 23);
            cmbOperador.TabIndex = 15;
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(319, 74);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(121, 23);
            cmbTema.TabIndex = 16;
            // 
            // txtIdCapacitacion
            // 
            txtIdCapacitacion.Location = new Point(764, 25);
            txtIdCapacitacion.Name = "txtIdCapacitacion";
            txtIdCapacitacion.Size = new Size(100, 23);
            txtIdCapacitacion.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(575, 29);
            label3.Name = "label3";
            label3.Size = new Size(156, 19);
            label3.TabIndex = 17;
            label3.Text = "ID del Capacitacion";
            // 
            // txtRutaEvidencia
            // 
            txtRutaEvidencia.Location = new Point(288, 249);
            txtRutaEvidencia.Name = "txtRutaEvidencia";
            txtRutaEvidencia.Size = new Size(100, 23);
            txtRutaEvidencia.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 231);
            label8.Name = "label8";
            label8.Size = new Size(145, 19);
            label8.TabIndex = 20;
            label8.Text = "URL de Evidencia";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(759, 635);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            textBox2.Visible = false;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(202, 314);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 22;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnSubirEvidencia
            // 
            btnSubirEvidencia.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirEvidencia.Location = new Point(248, 383);
            btnSubirEvidencia.Name = "btnSubirEvidencia";
            btnSubirEvidencia.Size = new Size(140, 61);
            btnSubirEvidencia.TabIndex = 23;
            btnSubirEvidencia.Text = "Subir Evidencia";
            btnSubirEvidencia.UseVisualStyleBackColor = true;
            btnSubirEvidencia.Click += btnSubirEvidencia_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(575, 383);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 61);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NuevaCapacitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 475);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSubirEvidencia);
            Controls.Add(chkActivo);
            Controls.Add(txtRutaEvidencia);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(txtIdCapacitacion);
            Controls.Add(label3);
            Controls.Add(cmbTema);
            Controls.Add(cmbOperador);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtObservaciones);
            Controls.Add(dtpFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCapacitacion);
            Name = "NuevaCapacitacion";
            Text = "NuevaCapacitacion";
            Load += NuevaCapacitacion_Load;
            Controls.SetChildIndex(btnCapacitacion, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(dtpFecha, 0);
            Controls.SetChildIndex(txtObservaciones, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(cmbOperador, 0);
            Controls.SetChildIndex(cmbTema, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtIdCapacitacion, 0);
            Controls.SetChildIndex(textBox2, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtRutaEvidencia, 0);
            Controls.SetChildIndex(chkActivo, 0);
            Controls.SetChildIndex(btnSubirEvidencia, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCapacitacion;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFecha;
        private TextBox txtObservaciones;
        private Label label6;
        private Label label7;
        private ComboBox cmbOperador;
        private ComboBox cmbTema;
        private TextBox txtIdCapacitacion;
        private Label label3;
        private TextBox txtRutaEvidencia;
        private Label label8;
        private TextBox textBox2;
        private CheckBox chkActivo;
        private Button btnSubirEvidencia;
        private Button btnLimpiar;
        private ErrorProvider errorProvider1;
    }
}