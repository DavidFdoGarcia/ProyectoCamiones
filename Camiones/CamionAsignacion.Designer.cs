namespace Camiones
{
    partial class CamionAsignacion
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
            label1 = new Label();
            txtIdAsignacion = new TextBox();
            txtObservaciones = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbCamionDetalle = new ComboBox();
            cmbOperador = new ComboBox();
            label4 = new Label();
            dtpFechaAsignacion = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dtpFechaFin = new DateTimePicker();
            chkActivvo = new CheckBox();
            chkSinFechaFin = new CheckBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            errorProvider1 = new ErrorProvider(components);
            dgAsignaciones = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgAsignaciones).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1138, 224);
            btnSalir.Size = new Size(85, 37);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 0;
            label1.Text = "ID de Asignación";
            // 
            // txtIdAsignacion
            // 
            txtIdAsignacion.Location = new Point(229, 31);
            txtIdAsignacion.Name = "txtIdAsignacion";
            txtIdAsignacion.Size = new Size(100, 23);
            txtIdAsignacion.TabIndex = 1;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(1007, 35);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(182, 143);
            txtObservaciones.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(846, 35);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 2;
            label2.Text = "Observaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 95);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 4;
            label3.Text = "Camión Detalle";
            // 
            // cmbCamionDetalle
            // 
            cmbCamionDetalle.FormattingEnabled = true;
            cmbCamionDetalle.Location = new Point(208, 91);
            cmbCamionDetalle.Name = "cmbCamionDetalle";
            cmbCamionDetalle.Size = new Size(121, 23);
            cmbCamionDetalle.TabIndex = 5;
            // 
            // cmbOperador
            // 
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Location = new Point(200, 153);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(121, 23);
            cmbOperador.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 153);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 6;
            label4.Text = "Operador";
            // 
            // dtpFechaAsignacion
            // 
            dtpFechaAsignacion.Location = new Point(581, 23);
            dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            dtpFechaAsignacion.Size = new Size(200, 23);
            dtpFechaAsignacion.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(371, 23);
            label5.Name = "label5";
            label5.Size = new Size(178, 19);
            label5.TabIndex = 9;
            label5.Text = "Fecha de Asignnacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(371, 73);
            label6.Name = "label6";
            label6.Size = new Size(84, 19);
            label6.TabIndex = 11;
            label6.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(554, 73);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 10;
            // 
            // chkActivvo
            // 
            chkActivvo.AutoSize = true;
            chkActivvo.Location = new Point(395, 139);
            chkActivvo.Name = "chkActivvo";
            chkActivvo.Size = new Size(60, 19);
            chkActivvo.TabIndex = 12;
            chkActivvo.Text = "Activo";
            chkActivvo.UseVisualStyleBackColor = true;
            // 
            // chkSinFechaFin
            // 
            chkSinFechaFin.AutoSize = true;
            chkSinFechaFin.Location = new Point(581, 139);
            chkSinFechaFin.Name = "chkSinFechaFin";
            chkSinFechaFin.Size = new Size(89, 19);
            chkSinFechaFin.TabIndex = 13;
            chkSinFechaFin.Text = "SinFechaFin";
            chkSinFechaFin.UseVisualStyleBackColor = true;
            chkSinFechaFin.CheckedChanged += chkSinFechaFin_CheckedChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(917, 231);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 28);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(1023, 231);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 28);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgAsignaciones
            // 
            dgAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAsignaciones.Location = new Point(33, 231);
            dgAsignaciones.Name = "dgAsignaciones";
            dgAsignaciones.Size = new Size(814, 288);
            dgAsignaciones.TabIndex = 16;
            dgAsignaciones.CellClick += dgAsignaciones_CellClick;
            dgAsignaciones.CellContentClick += dgAsignaciones_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(926, 313);
            button1.Name = "button1";
            button1.Size = new Size(107, 33);
            button1.TabIndex = 17;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CamionAsignacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 667);
            Controls.Add(button1);
            Controls.Add(dgAsignaciones);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(chkSinFechaFin);
            Controls.Add(chkActivvo);
            Controls.Add(label6);
            Controls.Add(dtpFechaFin);
            Controls.Add(label5);
            Controls.Add(dtpFechaAsignacion);
            Controls.Add(cmbOperador);
            Controls.Add(label4);
            Controls.Add(cmbCamionDetalle);
            Controls.Add(label3);
            Controls.Add(txtObservaciones);
            Controls.Add(label2);
            Controls.Add(txtIdAsignacion);
            Controls.Add(label1);
            Name = "CamionAsignacion";
            Text = "CamionAsignacion";
            Load += CamionAsignacion_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtIdAsignacion, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtObservaciones, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(cmbCamionDetalle, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(cmbOperador, 0);
            Controls.SetChildIndex(dtpFechaAsignacion, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(dtpFechaFin, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(chkActivvo, 0);
            Controls.SetChildIndex(chkSinFechaFin, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(dgAsignaciones, 0);
            Controls.SetChildIndex(button1, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgAsignaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdAsignacion;
        private TextBox txtObservaciones;
        private Label label2;
        private Label label3;
        private ComboBox cmbCamionDetalle;
        private ComboBox cmbOperador;
        private Label label4;
        private DateTimePicker dtpFechaAsignacion;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFechaFin;
        private CheckBox chkActivvo;
        private CheckBox chkSinFechaFin;
        private Button btnGuardar;
        private Button btnLimpiar;
        private ErrorProvider errorProvider1;
        private DataGridView dgAsignaciones;
        private Button button1;
    }
}