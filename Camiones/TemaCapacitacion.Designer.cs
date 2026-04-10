namespace Camiones
{
    partial class TemaCapacitacion
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
            panel1 = new Panel();
            rbInactivo = new RadioButton();
            rbActivo = new RadioButton();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            txtTema = new TextBox();
            lblTema = new Label();
            txtIdtema = new TextBox();
            btnGuardar = new Button();
            lbId = new Label();
            btnLimpiar = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(282, 343);
            // 
            // panel1
            // 
            panel1.Controls.Add(rbInactivo);
            panel1.Controls.Add(rbActivo);
            panel1.Location = new Point(83, 198);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 42);
            panel1.TabIndex = 1;
            // 
            // rbInactivo
            // 
            rbInactivo.AutoSize = true;
            rbInactivo.Location = new Point(102, 12);
            rbInactivo.Name = "rbInactivo";
            rbInactivo.Size = new Size(67, 19);
            rbInactivo.TabIndex = 7;
            rbInactivo.TabStop = true;
            rbInactivo.Text = "Inactivo";
            rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            rbActivo.AutoSize = true;
            rbActivo.Location = new Point(17, 12);
            rbActivo.Name = "rbActivo";
            rbActivo.Size = new Size(59, 19);
            rbActivo.TabIndex = 6;
            rbActivo.TabStop = true;
            rbActivo.Text = "Activo";
            rbActivo.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(65, 149);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(178, 146);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(218, 84);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(100, 23);
            txtTema.TabIndex = 3;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(50, 87);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(123, 15);
            lblTema.TabIndex = 2;
            lblTema.Text = "Tema de Capacitación";
            // 
            // txtIdtema
            // 
            txtIdtema.Location = new Point(163, 38);
            txtIdtema.Name = "txtIdtema";
            txtIdtema.Size = new Size(100, 23);
            txtIdtema.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(75, 268);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 36);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(50, 41);
            lbId.Name = "lbId";
            lbId.Size = new Size(49, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID Tema";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(194, 268);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 36);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // TemaCapacitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 444);
            Controls.Add(btnLimpiar);
            Controls.Add(panel1);
            Controls.Add(lbId);
            Controls.Add(btnGuardar);
            Controls.Add(lblDescripcion);
            Controls.Add(txtIdtema);
            Controls.Add(txtDescripcion);
            Controls.Add(txtTema);
            Controls.Add(lblTema);
            Name = "TemaCapacitacion";
            Text = "TemaCapacitacion";
            Load += TemaCapacitacion_Load;
            Controls.SetChildIndex(lblTema, 0);
            Controls.SetChildIndex(txtTema, 0);
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(txtIdtema, 0);
            Controls.SetChildIndex(lblDescripcion, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(lbId, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLimpiar;
        private Label lbId;
        private Button btnGuardar;
        private TextBox txtIdtema;
        private RadioButton rbInactivo;
        private Label lblTema;
        private RadioButton rbActivo;
        private TextBox txtTema;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private ErrorProvider errorProvider1;
    }
}