namespace Camiones
{
    partial class NuevoViaje
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
            btnLimpiar = new Button();
            btnSubirEvidencia = new Button();
            chkActivo = new CheckBox();
            txtRutaEvidencia = new TextBox();
            label8 = new Label();
            txtIdViaje = new TextBox();
            label1 = new Label();
            cmbDestinatario = new ComboBox();
            cmbOperador = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtObservaciones = new TextBox();
            label5 = new Label();
            btnCapacitacion = new Button();
            errorProvider1 = new ErrorProvider(components);
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(999, 637);
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(572, 401);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 61);
            btnLimpiar.TabIndex = 38;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSubirEvidencia
            // 
            btnSubirEvidencia.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirEvidencia.Location = new Point(245, 401);
            btnSubirEvidencia.Name = "btnSubirEvidencia";
            btnSubirEvidencia.Size = new Size(140, 61);
            btnSubirEvidencia.TabIndex = 37;
            btnSubirEvidencia.Text = "Subir Evidencia";
            btnSubirEvidencia.UseVisualStyleBackColor = true;
            btnSubirEvidencia.Click += btnSubirEvidencia_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(199, 332);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 36;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtRutaEvidencia
            // 
            txtRutaEvidencia.Location = new Point(285, 267);
            txtRutaEvidencia.Name = "txtRutaEvidencia";
            txtRutaEvidencia.Size = new Size(100, 23);
            txtRutaEvidencia.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(45, 249);
            label8.Name = "label8";
            label8.Size = new Size(145, 19);
            label8.TabIndex = 34;
            label8.Text = "URL de Evidencia";
            // 
            // txtIdViaje
            // 
            txtIdViaje.Location = new Point(761, 43);
            txtIdViaje.Name = "txtIdViaje";
            txtIdViaje.Size = new Size(100, 23);
            txtIdViaje.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(572, 47);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 32;
            label1.Text = "ID del Viaje";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbDestinatario
            // 
            cmbDestinatario.FormattingEnabled = true;
            cmbDestinatario.Location = new Point(316, 92);
            cmbDestinatario.Name = "cmbDestinatario";
            cmbDestinatario.Size = new Size(121, 23);
            cmbDestinatario.TabIndex = 31;
            // 
            // cmbOperador
            // 
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Location = new Point(316, 44);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(121, 23);
            cmbOperador.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 47);
            label7.Name = "label7";
            label7.Size = new Size(173, 19);
            label7.TabIndex = 29;
            label7.Text = "Nombre del Operador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 96);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 28;
            label6.Text = "Destino";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(665, 110);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(182, 134);
            txtObservaciones.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(496, 110);
            label5.Name = "label5";
            label5.Size = new Size(124, 19);
            label5.TabIndex = 26;
            label5.Text = "Observaciones";
            // 
            // btnCapacitacion
            // 
            btnCapacitacion.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapacitacion.Location = new Point(416, 401);
            btnCapacitacion.Name = "btnCapacitacion";
            btnCapacitacion.Size = new Size(140, 61);
            btnCapacitacion.TabIndex = 25;
            btnCapacitacion.Text = "Guardar";
            btnCapacitacion.UseVisualStyleBackColor = true;
            btnCapacitacion.Click += btnCapacitacion_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(295, 175);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 175);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 40;
            label4.Text = "Fecha de Viajje";
            // 
            // NuevoViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 713);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSubirEvidencia);
            Controls.Add(chkActivo);
            Controls.Add(txtRutaEvidencia);
            Controls.Add(label8);
            Controls.Add(txtIdViaje);
            Controls.Add(label1);
            Controls.Add(cmbDestinatario);
            Controls.Add(cmbOperador);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtObservaciones);
            Controls.Add(label5);
            Controls.Add(btnCapacitacion);
            Name = "NuevoViaje";
            Text = "NuevoViaje";
            Load += NuevoViaje_Load;
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnCapacitacion, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtObservaciones, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(cmbOperador, 0);
            Controls.SetChildIndex(cmbDestinatario, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtIdViaje, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtRutaEvidencia, 0);
            Controls.SetChildIndex(chkActivo, 0);
            Controls.SetChildIndex(btnSubirEvidencia, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(dtpFecha, 0);
            Controls.SetChildIndex(label4, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpiar;
        private Button btnSubirEvidencia;
        private CheckBox chkActivo;
        private TextBox txtRutaEvidencia;
        private Label label8;
        private TextBox txtIdViaje;
        private Label label1;
        private ComboBox cmbDestinatario;
        private ComboBox cmbOperador;
        private Label label7;
        private Label label6;
        private TextBox txtObservaciones;
        private Label label5;
        private Button btnCapacitacion;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtpFecha;
        private Label label4;
    }
}